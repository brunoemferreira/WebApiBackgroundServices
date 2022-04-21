# WebApiBackgroundServices

## Bibliotecas
* [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting)


Observações : 
> Foi criada uma biblioteca chamada Services, nela contém a classe ( InfoWorker ), que é chamada na inicialização ( Program.cs ) da API, sendo assim, cada classe que for criada em Services e for chamada dentro de Program.cs será inicializada uma thread paralela que significa que estas classes iniciarão juntamente com a API paralelamente subindo uma thread para cada uma.   


## Links Importantes
*[Background tasks with hosted services in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/hosted-services?view=aspnetcore-6.0&tabs=visual-studio)
