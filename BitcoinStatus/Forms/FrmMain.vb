Imports System.Net.Http
Imports BitcoinStatus.Domain
Imports Newtonsoft.Json

Public Class FrmMain

    Dim baseUri As String = "https://www.mercadobitcoin.net/api"

    Private Sub btGetDaySummary_Click(sender As Object, e As EventArgs) Handles btGetDaySummary.Click

        GetDaySummary()


    End Sub

    Private Async Sub GetDaySummary()
        Dim uri As String = baseUri & "/BTC/day-summary/2017/11/18/"
        Dim daySummaryObject As DaySummary

        Try


            Using client = New HttpClient

                Using response = Await client.GetAsync(uri)
                    If response.IsSuccessStatusCode Then
                        Dim daySummaryJSON = Await response.Content.ReadAsStringAsync()
                        daySummaryObject = JsonConvert.DeserializeObject(Of DaySummary)(daySummaryJSON)
                    End If

                End Using


            End Using

            Dim list As New List(Of DaySummary)
            list.Add(daySummaryObject)

            bsDaySummary.DataSource = list

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


End Class
