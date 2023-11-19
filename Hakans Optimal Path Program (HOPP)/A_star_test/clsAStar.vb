Public Structure CellData

#Region " Declares "
    Public OCList As Int16
    Public GCost As Int16
    Public SCost As Int16 'Slope cost
    Public TCost As Int16 'Terrain cost
    Public HCost As Int16
    Public FCost As Int16
    Public ParentX, ParentY As Int16
    Public Wall As Boolean
    Public DrawPath As Boolean
#End Region

End Structure

#Region " Binary Heap Objects "

Public Structure BinHeapData
    'Data Structure to hold FScore and Location
    Friend Score As Int16
    Friend X As Int16
    Friend Y As Int16
End Structure

Public Class BinaryHeap

#Region " Declares "
    Private lSize As Int16 'Size of the heap array
    Private Heap() As BinHeapData 'Heap Array
#End Region

#Region " Properties "

    'Return heap count
    Public ReadOnly Property Count() As Int16
        Get
            Return lSize
        End Get
    End Property

    'Return X position
    Public ReadOnly Property GetX() As Int16
        Get
            Return Heap(1).X
        End Get
    End Property

    'Return Y position
    Public ReadOnly Property GetY() As Int16
        Get
            Return Heap(1).Y
        End Get
    End Property

    'Return the lowest score
    Public ReadOnly Property GetScore() As Int16
        Get
            Return Heap(1).Score
        End Get
    End Property

#End Region

#Region " Subs "

    'Reset the heap
    Public Sub ResetHeap()
        lSize = 0
        ReDim Heap(0)
    End Sub

    'Remove the Root Object from the heap
    Public Sub RemoveRoot()

        'If only the root exists
        If lSize <= 1 Then
            lSize = 0
            ReDim Heap(0)
            Exit Sub
        End If

        'First copy the very bottom object to the top
        Heap(1) = Heap(lSize)

        'Resize the count
        lSize -= 1

        'Shrink the array
        ReDim Preserve Heap(lSize)

        'Sort the top item to it's correct position
        Dim Parent As Int16 = 1
        Dim ChildIndex As Int16 = 1

        'Sink the item to it's correct location
        While True
            ChildIndex = Parent
            If 2 * ChildIndex + 1 <= lSize Then
                'Find the lowest value of the 2 child nodes
                If Heap(ChildIndex).Score >= Heap(2 * ChildIndex).Score Then Parent = 2 * ChildIndex
                If Heap(Parent).Score >= Heap(2 * ChildIndex + 1).Score Then Parent = 2 * ChildIndex + 1
            Else 'Just process the one node
                If 2 * ChildIndex <= lSize Then
                    If Heap(ChildIndex).Score >= Heap(2 * ChildIndex).Score Then Parent = 2 * ChildIndex
                End If
            End If

            'Swap out the child/parent
            If Parent <> ChildIndex Then
                Dim tHeap As BinHeapData = Heap(ChildIndex)
                Heap(ChildIndex) = Heap(Parent)
                Heap(Parent) = tHeap
            Else
                Exit While
            End If

        End While

    End Sub

    'Add the new element to the heap
    Public Sub Add(ByVal inScore As Int16, ByVal inX As Int16, ByVal inY As Int16)

        '**We will be ignoring the (0) place in the heap array because
        '**it's easier to handle the heap with a base of (1..?)

        'Increment the array count
        lSize += 1

        'Make room in the array
        ReDim Preserve Heap(lSize)

        'Store the data
        With Heap(lSize)
            .Score = inScore
            .X = inX
            .Y = inY
        End With

        'Bubble the item to its correct location
        Dim sPos As Int16 = lSize

        While sPos <> 1
            If Heap(sPos).Score <= Heap(sPos / 2).Score Then
                Dim tHeap As BinHeapData = Heap(sPos / 2)
                Heap(sPos / 2) = Heap(sPos)
                Heap(sPos) = tHeap
                sPos /= 2
            Else
                Exit While
            End If
        End While

    End Sub

#End Region

End Class

#End Region
