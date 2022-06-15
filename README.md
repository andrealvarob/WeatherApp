# WeatherApp
Um breve aplicativo usando Xamarim Foms para disciplina de Dispositivos Móveis(2022.1)


# Resumo

O projeto tem como objetivo desenvolver um applicativo usando Xamarim Forms com os seguintes requisitos:

  - Possuir uma tela de login;
  - Possuir uma autenticação;
  - Possuir um gerenciamento de erros para autenticação;
  - Possuir um conexão com uma API externa;
  - Fazer tratamento de dados obtidos pela API;

Dados os requisitos enumerados anteriormente, elaborei uma aplicação que realiza login no sistema e devolve dados sobre o clíma da região onde o usuário decidir buscar.

# Recursos utilizados para o desenvolvimento

Para ajudar a criação da interface gráfica foram usadas imagens 
  
  > Designed by macrovector / Freepik & toutiaoap gallery, ícones foram baixados de <a>https://openweathermap.org/</a>

A repositório a seguir serviu como base para estudo sobre APIs

  > <a>https://github.com/public-apis/public-apis<a/>

Após ler toda documentaçãao, escolhi a API openweather para fornecer as informações que eu precisava sobre o clíma
  
  > <a>https://openweathermap.org/current</a>

E finalmente, para converter as informações do arquivo json para dados validos no meu programa utilizei um NuGet Package que deve ser instalado para a aplicação funcionar
  
  > newtonsoft.json
  
  # Sobre o desenvolvimento
  
  Basicamente o meu projeto seguiu o padrão MVC, meus principais Models são WeatherData que contém as classes que irão receber as informações da API
  
  <font color="#CCA3F9">This is some text!</font>
  
```csharp
    public class WeatherData
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
```
  
 e UserData, que irá definir os usuários do sistema
  
  ```csharp
       class UserData
    {
        public String name { get; set; }
        public String password { get; set; }
        public String email { get; set; }

        public UserData(String name, String password, String email)
        {
            this.name = name;
            this.password = password;
            this.email = email;
        }
    }
```


