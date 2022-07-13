<?php

$curl = curl_init();

curl_setopt_array($curl, array(
  CURLOPT_URL => 'https://stage.api.enviame.io/api/s2/v2/marketplaces/35/companies/620/deliveries',
  CURLOPT_RETURNTRANSFER => true,
  CURLOPT_ENCODING => '',
  CURLOPT_MAXREDIRS => 10,
  CURLOPT_TIMEOUT => 0,
  CURLOPT_FOLLOWLOCATION => true,
  CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
  CURLOPT_CUSTOMREQUEST => 'POST',
  CURLOPT_POSTFIELDS =>'{
    "shipping_order": {
        "n_packages": 1,
        "content_description": "Product description",
        "imported_id": "CL9712070429",
        "order_price": 21990.0,
        "weight": "1.0",
        "volume": "1.0",
        "type": "delivery"
    },
    "shipping_origin": {
        "warehouse_code": "my_warehouse"
    },
    "shipping_destination": {
        "customer": {
            "name": "roberto pavez basualto",
            "email": "roberto@gmail.com",
            "phone": "952458445"
        },
        "delivery_address": {
            "home_address": {
                "place": "Curico",
                "full_address": "Avenida Diego Portales  1197"
            }
        }
    },
    "carrier": {
        "carrier_code": "CCH",
        "carrier_service":"",
        "tracking_number": ""
    }
}',
  CURLOPT_HTTPHEADER => array(
    'Accept: application/json',
    'api-key: ',
    'Content-Type: application/json'
  ),
));

$response = curl_exec($curl);

curl_close($curl);
echo $response;

