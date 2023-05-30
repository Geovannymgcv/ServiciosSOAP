<?php

$cliente = new SoapClient('https://localhost:57798/Service1.svc?wsdl');

$ProcesarPago = $cliente->ProcesarPago([
    "total" => 1000,
    "pago" => 100
])->return; 

if ($ProcesarPago >=0){
    echo 'Pago Realizado';
}else{
    echo 'Dinero Insuficiente';
}