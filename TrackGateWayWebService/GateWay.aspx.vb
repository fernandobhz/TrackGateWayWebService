Public Class GateWay
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SmartGT call: http://sistema.xxxxxx.com.br/servidor/gateway.php?protocol=SMARTGT06&imei=0864717002958290&lat=-22.784293333333334&long=-43.28545333333333&altura=0.0&speed=86.0&gpsSignalIndicator=F&satellites_avaliable=10&sensors_status=&actuators_status=N0NNNNN0&tipo_mensagem=03&odometer=0&direction=&date_gps=20130207052533&fw=1.0&ignicao_sensor=N&bateria=&heading=358.0&nm_servidor=leandroVPS&gsm_signal=100&cell_location=41921&cell_id=27082&cell_mcc=724&cell_mnc=2&cell_lbs=0&bateria_veiculo=N&original=78781F120D0207051921CA0271CA1004A4DED856196602D402A3C10069CA08FDA6A70D0A
        'SmartGT call:
        'http://sistema.bravosat.com.br/servidor/gateway.php
        '?protocol=SMARTGT06
        '&imei=0864717002958290
        '&lat=-22.784293333333334
        '&long=-43.28545333333333
        '&altura=0.0
        '&speed=86.0
        '&gpsSignalIndicator=F
        '&satellites_avaliable=10
        '&sensors_status=
        '&actuators_status=N0NNNNN0
        '&tipo_mensagem=03
        '&odometer=0
        '&direction=
        '&date_gps=20130207052533
        '&fw=1.0
        '&ignicao_sensor=N
        '&bateria=
        '&heading=358.0
        '&nm_servidor=leandroVPS
        '&gsm_signal=100
        '&cell_location=41921
        '&cell_id=27082
        '&cell_mcc=724
        '&cell_mnc=2
        '&cell_lbs=0
        '&bateria_veiculo=N
        '&original=78781F120D0207051921CA0271CA1004A4DED856196602D402A3C10069CA08FDA6A70D0A

        Dim Q As New DSTransmissaoTableAdapters.QueriesTableAdapter
        Q.transmissao_insert(My.Request.RawUrl)

        Response.Clear()
        'Tudo que enviar como resposta o gateway pega e mando para o equipamento como um COMANDO
        Response.End()
    End Sub

End Class