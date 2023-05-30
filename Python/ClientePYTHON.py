from zeep import Client

#cliente
cliente = Client('https://localhost:57798/Service1.svc?wsdl')

#Login
if cliente.service.Login("user","1234"):
    print("Todo Correcto")
else:
    print("Credenciales Incorrectas")

#Procesar PAgo
if cliente.service.ProcesarPago(5000,100)>=0:
    print("Pago realizado")
else:
    print("Dinero insuficiente")