Module Module1
    Sub Main()
        ' 現在の日付を取得
        Dim now As DateTime = DateTime.Now

        ' 年、月、日を取得
        Dim year As Integer = now.Year
        Dim month As Integer = now.Month
        Dim day As Integer = now.Day

        ' 年-月-日の形式で表示
        Console.WriteLine($"日付: {year}-{month:D2}-{day:D2}")
    End Sub
End Module
