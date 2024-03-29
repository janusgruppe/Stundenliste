﻿Public NotInheritable Class Intro

    'TODO: Dieses Formular kann einfach als Begrüßungsbildschirm für die Anwendung festgelegt werden, indem Sie zur Registerkarte "Anwendung"
    '  des Projekt-Designers wechseln (Menü "Projekt", Option "Eigenschaften").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Richten Sie den Dialogtext zur Laufzeit gemäß den Assemblyinformationen der Anwendung ein.  

        'TODO: Passen Sie die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
        '  Projekteigenschaften (im Menü "Projekt") an.

        'Anwendungstitel
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Wenn der Anwendungstitel fehlt, Anwendungsnamen ohne Erweiterung verwenden
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Verwenden Sie zum Formatieren der Versionsinformationen den Text, der zur Entwurfszeit in der Versionskontrolle festgelegt wurde, als
        '  Formatierungszeichenfolge. Dies ermöglicht ggf. eine effektive Lokalisierung.
        '  Build- und Revisionsinformationen können durch Verwendung des folgenden Codes und durch Ändern 
        '  des Entwurfszeittexts der Versionskontrolle in "Version {0}.{1:00}.{2}.{3}" oder einen ähnlichen Text eingeschlossen werden. Weitere Informationen erhalten Sie unter
        '  String.Format() in der Hilfe.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyrightinformationen
        Copyright.Text = My.Application.Info.Copyright

        'Benutzer ermitteln
        If TypeOf My.User.CurrentPrincipal Is Security.Principal.WindowsPrincipal And My.User.IsInRole("S_User") Then
            Label1.Text = "Sie sind angemeldet als " & My.User.Name
        Else
            MsgBox("Sie haben keinen Zugriff auf dieses Programm" & vbCrLf & "Bitte melden Sie sich beim Administrator oder beten tuts auch.")
            End
        End If

    End Sub


End Class
