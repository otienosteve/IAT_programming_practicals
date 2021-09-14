Module Module1

    Sub Main()
        Dim num(,,) As Integer = {{{1, 2}, {3, 4}, {5, 6}}, {{7, 8}, {9, 10}, {11, 12}}}
        Dim num2 As Integer = 0
        Dim num3 As Integer = 0
        Dim num4 As Integer = 0
      
        For num2 = 0 To 1
            For num3 = 0 To 2
                For num4 = 0 To 1
                    Console.WriteLine("num[{0},{1},{2}]={3}", num2, num3, num4, num(num2, num3, num4))
                Next
            Next
        Next
        Console.ReadLine()



    End Sub

End Module
