# Setup projeto .NET

Veja como configurar seu projeto da "maneira certa" desde o início do projeto. Isso inclui tudo, desde a configuração básica até ferramentas incríveis - como usar o .editorconfig para manter seu código limpo, gerenciar todos os seus pacotes em um só lugar e detectar bugs cedo com análise de código. 
Além disso, você aprenderá como empacotar sua aplicação com Docker, orquestrá-la usando Docker Compose ou o novíssimo .NET Aspire, e automatizar seus builds com GitHub Actions. Perfeito para quem quer elevar o nível no .NET e construir projetos como um profissional.

## Melhores práticas setup projeto .NET

1. **Editor Config**: para definir um code style padrão no projeto. Exemplos de repositórios com configurações:
	- https://gist.github.com/m-jovanovic/417b7d0a641d7dd7d1972550fba298db
	- https://github.com/dotnet/runtime/blob/main/.editorconfig

2. **Build Configuration**: isto fará que seja aplicada as configurações de build em todos os projetos da solução. No projeto o nome é *Directory.Build.props*

3. **Central Package Management**: para configurar as versões de todos os pacotes Nugets utilizados no projeto e na solução. Se encontra no arquivo *Directory.Packages.props*. Quando é desejado instalar um pacote Nuget ele sempre vai para este arquivo com a versão desejada.

4. **Code Analysis**: para verificar e validar o código fonte com possíveis bugs, melhores práticas e afins.

5. **Containerization**: uso de docker e docker-compose através do próprio scafold padrão que o Visual Studio te provê via interface.
	- Para o docker basta: clicar botão direito no projeto => Adicionar => Suporte ao docker
	- Para o docker-compose basta: clicar botão direito no projeto => Adicionar => Suporte orquestrador de container

6. **.NET Aspire**: é uma stack out-of-box provida pela Microsoft para criação de aplicações "ready to cloud", com suportes a observabilidade, monitoramento, diversos componentes de software via containers e afins. Ou seja, ele pode ser um substituto ao orquestrador de containers Docker compose.
	- Para configurá-lo na aplicação host basta: clicar botão direito no projeto => Adicionar => Suporte ao Orquestrador do .NET Aspire

7. **CI/CD**: usar o poder dos pipelines para integração contínua da aplicação e deploys automatizados para o serviço de computação em nuvem que esteja utilizando. No projeto contém um arquivo chamado *build.yml* contendo configuração básica para rodar no pipeline do github actions.

## Referências
- [Vídeo base](https://www.youtube.com/watch?v=QRgtcbxJlo0)

## À Fazer

- Ajustar os projetos criados pelo .NET Aspire (AppHost & ServiceDefaults) de forma a compilar todos os projetos da solução. O erro é devido a criação dos arquivos de gerenciamento das versões de dependências e build do projeto WebApi.
- Organizar a estrutura do projeto logicamente dentro da sln (solution) contendo o diretório /src com o recursos e código fonte para rodar o projeto.