# Virtual Aquarium

Virtual Aquarium it's my undergraduate thesis to simulate an aquarium that is controlled by Tangible User Interface.  
The project it's a Unity Game that is controlled by NodeMCU (ESP8266). The components connected in ESP8266 send commands to Unity to execute actions in the game.  

Languages:
   - C#
   - C

Pré-requisitos:  
Roteador WiFi com protocolo IGMP ativo e SSID e senha, não pode ser WiFi com autenticação de usuário (ex.: WiFi FURB) e também não funciona no hotspot do celular, pois não possui IGMP (na maioria).  

1- Instalar a apk em um dispositivo Android  
2- Obter o kit de IUT (Falar com professor Dalton)  
3- Conectar o kit na tomada  
4- Aguardar o LED inferior acender  
5- Conectar o dispositivo móvel na rede WiFi Aquario com a senha aquario-virtual  
6- Abrir o VirtualAquarium no dispositivo e acessar as configurações, informar o token AQUARIUM_01 e WiFi e senha desejados  
7- Apertar em Confirmar e aguardar o kit reiniciar  
8- Verificar se o LED do meio do kit acendeu, significa conectado ao WiFi  
9- Conectar o dispositivo móvel no mesmo WiFi configurado no kit  
10- Pressionar em jogar, verificar se o LED de cima no kit acendeu  
