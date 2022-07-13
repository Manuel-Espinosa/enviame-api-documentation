var client = new RestClient("https://stage.api.enviame.io/api/s2/v2/marketplaces/35/companies/620/deliveries");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Accept", "application/json");
request.AddHeader("api-key", "");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +
@"    ""shipping_order"": {" + "\n" +
@"        ""n_packages"": 1," + "\n" +
@"        ""content_description"": ""Product description""," + "\n" +
@"        ""imported_id"": ""CL9712070429""," + "\n" +
@"        ""order_price"": 21990.0," + "\n" +
@"        ""weight"": ""1.0""," + "\n" +
@"        ""volume"": ""1.0""," + "\n" +
@"        ""type"": ""delivery""" + "\n" +
@"    }," + "\n" +
@"    ""shipping_origin"": {" + "\n" +
@"        ""warehouse_code"": ""my_warehouse""" + "\n" +
@"    }," + "\n" +
@"    ""shipping_destination"": {" + "\n" +
@"        ""customer"": {" + "\n" +
@"            ""name"": ""roberto pavez basualto""," + "\n" +
@"            ""email"": ""roberto@gmail.com""," + "\n" +
@"            ""phone"": ""952458445""" + "\n" +
@"        }," + "\n" +
@"        ""delivery_address"": {" + "\n" +
@"            ""home_address"": {" + "\n" +
@"                ""place"": ""Curico""," + "\n" +
@"                ""full_address"": ""Avenida Diego Portales  1197""" + "\n" +
@"            }" + "\n" +
@"        }" + "\n" +
@"    }," + "\n" +
@"    ""carrier"": {" + "\n" +
@"        ""carrier_code"": ""CCH""," + "\n" +
@"        ""carrier_service"":""""," + "\n" +
@"        ""tracking_number"": """"" + "\n" +
@"    }" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);