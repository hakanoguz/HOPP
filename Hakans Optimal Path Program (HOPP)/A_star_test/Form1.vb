Imports System
Imports System.IO
Imports System.Drawing
Public Class Form1


    'Dim oBuffG As New Bitmap(PictureBox1.width, PictureBox1.height)
    'Dim g As Graphics = Graphics.FromImage(oBuffG)

    


    Dim width_ = InputBox("Enter the WIDTH of the map (# of pixels)...")
    Dim height_ = InputBox("Enter the HEIGHT of the map (# of pixels)...")

    'Public width_ As Integer
    'Public height_ As Integer
    Private Const inOpened = 1
    Private Const inClosed = 2
    Private Heap As New BinaryHeap()
    Private StartX, StartY, EndX, EndY As Int16
    Private Map(width_, height_) As CellData
    Private PathFound, PathHunt As Boolean
    Private ParentX, ParentY As Int16

    

    Public TerrainData(,) As Byte
    Public SlopeData(,) As Byte
    Public RoadsData(,) As Byte
    'g.Dispose()


    'Dim StartX, StartY, EndX, EndY As Int16

    Private Sub FindPath()

        
        Dim xCnt, yCnt As Int16

        'Make sure the starting point and ending point are not the same
        If (StartX = EndX) And (StartY = EndY) Then Exit Sub
        'MessageBox.Show("startx= " & StartX & "starty= " & StartY)


        'Make sure the starting point is not a wall
        If Map(StartX, StartY).Wall Then Exit Sub
        If Map(EndX, EndY).Wall Then Exit Sub

        'Set the flags
        PathFound = False
        PathHunt = True

        'Put the starting point on the open list
        Map(StartX, StartY).OCList = inOpened
        Heap.Add(0, StartX, StartY)

        'Find the children
        While PathHunt
            If Heap.Count <> 0 Then
                'Get the parent node
                ParentX = Heap.GetX
                ParentY = Heap.GetY

                'Remove the root
                Map(ParentX, ParentY).OCList = inClosed
                Heap.RemoveRoot()

                'Find the available children to add to the open list
                For yCnt = (ParentY - 1) To (ParentY + 1)
                    For xCnt = (ParentX - 1) To (ParentX + 1)

                        'Make sure we are not out of bounds
                        If xCnt <> -1 And xCnt < width_ And yCnt <> -1 And yCnt < height_ Then

                            'Make sure it is not wall (water is set to wall)
                            If TerrainData(xCnt, yCnt) < 250 Then

                                ''Make sure it is lower than the max slope of 25%
                                If SlopeData(xCnt, yCnt) < 100 Then

                                    'Make sure it's not on the closed list
                                    If Map(xCnt, yCnt).OCList <> inClosed Then

                                        'Make sure no wall
                                        If Map(xCnt, yCnt).Wall = False Then

                                            'Don't cut across corners
                                            Dim CanWalk As Boolean = True
                                            If xCnt = ParentX - 1 Then
                                                If yCnt = ParentY - 1 Then
                                                    If Map(ParentX - 1, ParentY).Wall = True Or Map(ParentX, ParentY - 1).Wall = True Then CanWalk = False
                                                ElseIf yCnt = ParentY + 1 Then
                                                    If Map(ParentX, ParentY + 1).Wall = True Or Map(ParentX - 1, ParentY).Wall = True Then CanWalk = False
                                                End If
                                            ElseIf xCnt = ParentX + 1 Then
                                                If yCnt = ParentY - 1 Then
                                                    If Map(ParentX, ParentY - 1).Wall = True Or Map(ParentX + 1, ParentY).Wall = True Then CanWalk = False
                                                ElseIf yCnt = ParentY + 1 Then
                                                    If Map(ParentX + 1, ParentY).Wall = True Or Map(ParentX, ParentY + 1).Wall = True Then CanWalk = False
                                                End If
                                            End If

                                            'If we can move this way
                                            If CanWalk = True Then
                                                If Map(xCnt, yCnt).OCList <> inOpened Then

                                                    'Calculate the GCost
                                                    If Math.Abs(xCnt - ParentX) = 1 And Math.Abs(yCnt - ParentY) = 1 Then
                                                        Map(xCnt, yCnt).GCost = (Map(ParentX, ParentY).GCost * 1.4)
                                                    Else
                                                        Map(xCnt, yCnt).GCost = Map(ParentX, ParentY).GCost * 1.0
                                                    End If

                                                    'Calculate the HCost
                                                    Map(xCnt, yCnt).HCost = 1.0 * (Math.Abs(xCnt - EndX) + Math.Abs(yCnt - EndY))

                                                    'Calculate the TCost

                                                    Map(xCnt, yCnt).TCost = TerrainData(xCnt, yCnt)


                                                    'Calculate the SCost
                                                    Map(xCnt, yCnt).SCost = SlopeData(xCnt, yCnt)
                                                    'If SlopeData(ParentX, ParentY) > 25 Then
                                                    '    Map(xCnt, yCnt).SCost = 200
                                                    'Else
                                                    '    Map(xCnt, yCnt).SCost = SlopeData(xCnt, yCnt)
                                                    'End If

                                                    'Calculate the total Cost
                                                    Map(xCnt, yCnt).FCost = (Map(xCnt, yCnt).GCost + Map(xCnt, yCnt).HCost + Map(xCnt, yCnt).TCost + Map(xCnt, yCnt).SCost)
                                                    'Map(xCnt, yCnt).FCost = (Map(xCnt, yCnt).GCost + Map(xCnt, yCnt).HCost + Map(xCnt, yCnt).TCost)

                                                    'MessageBox.Show("xCnt= " & xCnt & "yCnt" & yCnt & "(xCnt,yCnt)= " & RoadsData(xCnt, yCnt))
                                                    'MessageBox.Show("xCnt= " & xCnt & "yCnt" & yCnt & "(xCnt,yCnt)= " & SlopeData(xCnt, yCnt) & "ParentX= " & ParentX & "ParentY= " & ParentY & " (ParentX,ParentY)= " & SlopeData(ParentX, ParentY))
                                                    'Add the parent value
                                                    Map(xCnt, yCnt).ParentX = ParentX
                                                    Map(xCnt, yCnt).ParentY = ParentY

                                                    'Add the item to the heap
                                                    Heap.Add(Map(xCnt, yCnt).FCost, xCnt, yCnt)

                                                    'Add the item to the open list
                                                    Map(xCnt, yCnt).OCList = inOpened

                                                Else
                                                    'We will check for better value // Hakan edited here 
                                                    Dim AddedGCost As Single
                                                    If Math.Abs(xCnt - ParentX) = 1 And Math.Abs(yCnt - ParentY) = 1 Then
                                                        AddedGCost = 1.4
                                                    Else
                                                        AddedGCost = 1.0
                                                    End If
                                                    Dim tempCost As Int16 = Map(ParentX, ParentY).GCost + AddedGCost

                                                    If tempCost < Map(xCnt, yCnt).GCost Then
                                                        Map(xCnt, yCnt).GCost = tempCost
                                                        Map(xCnt, yCnt).ParentX = ParentX
                                                        Map(xCnt, yCnt).ParentY = ParentY
                                                        If Map(xCnt, yCnt).OCList = inOpened Then
                                                            Dim NewCost As Int16 = Map(xCnt, yCnt).HCost + Map(xCnt, yCnt).GCost
                                                            Heap.Add(NewCost, xCnt, yCnt)
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Next
                Next
            Else
                PathFound = False
                PathHunt = False
                Exit Sub
            End If

            'If we find a path
            If Map(EndX, EndY).OCList = inOpened Then
                PathFound = True
                PathHunt = False
            End If

        End While

        If PathFound Then
            Dim tX As Int16 = EndX
            Dim tY As Int16 = EndY
            Map(tX, tY).DrawPath = True
            While True
                Dim sX As Int16 = Map(tX, tY).ParentX
                Dim sY As Int16 = Map(tX, tY).ParentY
                Map(sX, sY).DrawPath = True
                tX = sX
                tY = sY
                If tX = StartX And tY = StartY Then Exit While
            End While

            Render()

        End If

    End Sub

    Private Sub Render()
        Dim xCnt, yCnt As Int16

        Try
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\lulc.gif")
        Catch ex As FileNotFoundException
            MsgBox("Input map not found! Make sure that the file exists!!!", MsgBoxStyle.Exclamation, "ERROR")
            Application.Exit()
            Me.Close()
            Exit Sub
        End Try


        Dim oBuffG As New Bitmap(PictureBox1.Image.Width, PictureBox1.Image.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb)
        Dim g As Graphics = Graphics.FromImage(CType(oBuffG, Image))
        g.DrawImage(PictureBox1.Image, 0, 0)
        g.Dispose()
        PictureBox1.Image.Dispose()
        PictureBox1.Image = oBuffG


        oBuffG.SetPixel(StartX, StartY, Color.Green)
        oBuffG.SetPixel(EndX, EndY, Color.Red)

        'Draw the walls
        For yCnt = 0 To height_ - 1
            For xCnt = 0 To width_ - 1
                If Map(xCnt, yCnt).Wall = True Then oBuffG.SetPixel(xCnt, yCnt, Color.White)
                If Map(xCnt, yCnt).DrawPath = True Then
                    oBuffG.SetPixel(xCnt, yCnt, Color.White)
                End If
            Next
        Next

        PictureBox1.Image = oBuffG
    End Sub

    'Browse for the map image
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        '    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        'End If
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select terrain map"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox1.Text = ""
            Dim loadFileName1 As String = OpenFD.FileName

            'show the full path of selected file in TextBox1
            TextBox1.AppendText(loadFileName1)
        End If
    End Sub

    'Starting, Destination and Wall points are set here
    Private Sub PictureBox1_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        'Handle mouse down events
        If e.Button = MouseButtons.Left Then
            Dim xPos As Int16 = e.X
            Dim yPos As Int16 = e.Y

            'Process the click based on the radio button checked
            If radStart.Checked Then
                StartX = xPos
                StartY = yPos
                Label1.Text = "Starting Point (X,Y): (" & StartX & "," & StartY & ")"
            ElseIf radEnd.Checked Then
                EndX = xPos
                EndY = yPos
                Label2.Text = "Destination Point (X,Y): (" & EndX & "," & EndY & ")"
            ElseIf radWall.Checked Then
                If Map(xPos, yPos).Wall = True Then
                    Map(xPos, yPos).Wall = False
                Else
                    Map(xPos, yPos).Wall = True
                    Label3.Text = "Wall Point (X,Y): (" & xPos & "," & yPos & ")"
                End If
            End If

        End If

    End Sub

    'Find path
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

       

        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
            MessageBox.Show("Please select the maps first!", "Warning!")
            Me.TextBox1.Focus()

        Else
            'MessageBox.Show("Starting (X,Y)= (" & StartX & "," & StartY & ")")
            'MessageBox.Show("Ending (X,Y)= (" & EndX & "," & EndY & ")")

           

            Button2.Text = "Processing"
            Button2.Enabled = False

            FindPath()
         
            Button3.Enabled = True
            Button2.Text = "DONE!"


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        'Label4.Text = ""
        Label5.Text = ""
    

        Button2.Text = "Find Optimal Path"
        Button3.Enabled = False
        Button2.Enabled = True
        PictureBox1.Image = Nothing

        Dim xCnt, yCnt As Int16
        Heap.ResetHeap()
        For yCnt = 0 To height_ - 1
            For xCnt = 0 To width_ - 1
                With Map(xCnt, yCnt)
                    .DrawPath = False
                    .FCost = 0
                    .GCost = 0
                    .HCost = 0
                    .SCost = 0
                    .TCost = 0
                    .OCList = 0
                    .ParentX = 0
                    .ParentY = 0
                End With
            Next
        Next
        Render()
    End Sub

    Public Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        
        
        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        'Me.TextBox4.Clear()
        'Me.TextBox5.Clear()

    End Sub


    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Render()
    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Loadbtn.Click

 
        If TextBox1.Text.Length = 0 Or TextBox2.Text.Length = 0 Then
            MessageBox.Show("Please select the maps first!", "Warning!")
            Me.TextBox1.Focus()

        Else
            Dim s1 As FileStream 'Load file 1
            Dim s2 As FileStream 'Load file 1


            '---read terrain (lulc) file
            s1 = New FileStream(TextBox1.Text, FileMode.Open, FileAccess.Read)

    
            Dim br1 As BinaryReader
            br1 = New BinaryReader(s1)

            Dim byteRead1(width_ - 1, height_ - 1) As Byte

            Dim x As Integer
            Dim y As Integer
            For y = 0 To height_ - 1
                For x = 0 To width_ - 1
                    byteRead1(x, y) = br1.ReadByte
  
                Next
            Next
            TerrainData = byteRead1
            s1.Close()



            '-----------------------------------------------------------------------

            '---read slope image file
            s2 = New FileStream(TextBox2.Text, FileMode.Open, FileAccess.Read)
            Dim br2 As BinaryReader
            br2 = New BinaryReader(s2)

            Dim byteRead2(width_ - 1, height_ - 1) As Byte

            Dim i As Integer
            Dim j As Integer

            For j = 0 To height_ - 1
                For i = 0 To width_ - 1
                    byteRead2(i, j) = br2.ReadByte
                Next
            Next
            SlopeData = byteRead2
            s2.Close()
            'Me.Label6.Text = "Slope map loaded succesfully!"
            'Me.Label4.Text = "Slope(585, 338)= " & byteRead2(585, 338)

           
            Me.Label5.Text = "Maps loaded!"
        End If
    End Sub
    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Multiselect = False
        OpenFD.Title = "Select slope map"
        OpenFD.Filter = "All Files [*.*]| *.*"
        ' Make sure the User clicked OK and not Cancel
        If (OpenFD.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            TextBox2.Text = ""
            Dim loadFileName2 As String = OpenFD.FileName

            'show the full path of selected file in TextBox1
            TextBox2.AppendText(loadFileName2)
        End If
    End Sub

    'Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If OpenFD.ShowDialog() = DialogResult.OK Then
    '        PictureBox1.Image = Image.FromFile(OpenFD.FileName)
    '    End If

    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
