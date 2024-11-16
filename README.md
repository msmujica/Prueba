<<<<<<< HEAD
<img alt="UCU" src="https://www.ucu.edu.uy/plantillas/images/logo_ucu.svg"
width="150"/>

# Universidad Católica del Uruguay

## Facultad de Ingeniería y Tecnologías

### Programación II

Pequeña demo de un bot de Discord en C# usando un
[*façade*](https://refactoring.guru/design-patterns/facade) o fachada.

> [!IMPORTANT]
> Pueden ver que es posible programar toda la funcionalidad pedida en la
> *façade* sin preocuparse por el bot de Discord y agregar al final la
> funcionalidad del bot sin modificaciones a la *façade* en la ultima entrega.

# Façade

Para que vean cómo es posible implementar las historias de usuario usando un
*façade*, les damos un ejemplo en [`Program`](/src/Program/Program.cs) en el que
los jugadores `player` y `opponent` se unen a la lista de espera para jugar para
jugar, luego se muestra que ambos están en la lista, luego se inicia una batlla
entre ellos, y finalmente se muestra que ningún jugador espera para jugar.

La carpeta [`Domain`](/src/Library/Domain/) tienen todas las clases utilizadas
por la *façade*.

Esta *façade* implementa las historias de usuario:

9. Como entrenador, quiero unirme a la lista de jugadores esperando por un
   oponente.

  * Criterios de aceptación:
     * El jugador recibe un mensaje confirmando que fue agregado a la lista de
       espera.

   > Es el método `AddTrainerToWaitingList` de la clase [`Facade`](/src/Library/Domain/Facade.cs).

10. Como entrenador, quiero ver la lista de jugadores esperando por un oponente.

  * Criterios de aceptación:
    * En la pantalla se ve la lista de jugadores que se unieron a la lista de
      espera.

   > Es el método `GetAllTrainersWaiting` de la clase [`Facade`](/src/Library/Domain/Facade.cs).

11. Como entrenador, quiero iniciar una ballata con un jugador que está
    esperando por un oponente.

  * Criterios de aceptación:
    * Ambos jugadores son notificados del inicio de la batalla
    * El jugador que tiene el primer turno se determina aleatoriamente.

   > Es el método `CreateBattle`  de la clase [`Facade`](/src/Library/Domain/Facade.cs).

# Demo de bots de Discord

Para probar el bot:

1. Comenta en [`Program`](/src/Program/Program.cs) la línea que dice
   `DemoFacade();` y quita el comentario a la que dice `DemoBot();`.

2. Crea un nuevo bot en Discord siguiendo [estas
   instrucciones](https://docs.discordnet.dev/guides/getting_started/first-bot.html);
   anota el token que te muestra la página. Cuando sigas el procedimiento y
   tengas las opciones `Install to user account` o `Install to server`, elije
   `Install to server`; vas a tener que crear un server para probar tu bot.

3. Crea un archivo `secrets.json` en las siguientes ubicaciones dependiendo de
   tu sistema operativo; si no existe alguna de las carpetas en la ruta
   deberás crearla;`%APPDATA%` en Windows siempre existe, así como `~`
   siempre existe en Linux/macOS-:

   - **Windows**: `%APPDATA%\\Microsoft\\UserSecrets\\PII_DiscordBot_Demo\\secrets.json`
   - **Linux/macOs**: `~/.microsoft/usersecrets/PII_DiscordBot_Demo/secrets.json

4. Edita el archivo `secrets.json` para que contenga la configuración que
   aparece a continuación, donde reemplazas `<token>` por el que te dio el
   Discord:
    ```json
    {
    "DiscordToken": "<token>"
    }
    ```

> 🤔 ¿Porqué la complicamos?
>
> De esta forma vas a poder subir el código de tu bot a repositorios de
> GitHub sin compartir el token de tu bot. No vas a tener que hacerlo ahora,
> pero si en algún momento quieres ejecutar tu bot en otro ambiente como un
> servidor de producción o en Azure, podrás configurar el token secreto en forma
> segura.

En la demo de un bot de telegram en C#, el bot responde a los
siguientes mensajes:

- `!who[{username}]`: `username` es opcional. Devuelve información sobre el
  usuario que envía el mensaje o sobre el usuario `username`.
- `!join`: Une el jugador que envía el mensaje a la lista de jugadores esperando
  para jugar. Es la historia de usuario #9.
- `!leave`: Remueve el jugador de la lista de jugadores esperando para jugar.
- `!waiting`: Muestra la lista de juegadores esperando para jugar. Es la
  historia de usuario #10.
- `!battle {username}`: Inicia una batalla contra `username`; `username` debe
  estar esperando para jugar.
- 🎁 `!name {id}`: Devuelve el nombre del Pokémon con ese id.

> {!TIP}
> El comando `!name` muestra cómo obtener información de pokémons usando una API
> REST. En este comando podrás ver cómo atrapar excepciones.

La carpeta [`Commands`](/src/Library/Commands/) tienen todas las clases utilizadas
por los comandos del bot.

> [!WARNING]
> **Esto es una demo**. No tomen ese ejemplo como la solución correcta de
> ninguna de las historias de usuario.

> [!IMPORTANT]
> Este bot está basado en [este tutorial](https://blog.adamstirtan.net/2023/10/create-discord-bot-in-c-and-net-part-1.html).
=======
# Qué hay configurado en esta plantilla

1. Un proyecto de biblioteca (creado con [`dotnet new classlib --name Library`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Library`
2. Un proyecto de aplicación de consola (creado con [`dotnet new console --name Program`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `src\Program`
3. Un proyecto de prueba en [NUnit](https://nunit.org/) (creado con [`dotnet new nunit --name LibraryTests`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new?tabs=netcore22)) en la carpeta `test\LibraryTests`
4. Un proyecto de [Doxygen](https://www.doxygen.nl/index.html) para generación de sitio web de documentación en la carpeta `docs`
5. Análisis estático con [Roslyn analyzers](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview) en los proyectos de biblioteca y de aplicación
6. Análisis de estilo con [StyleCop](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/README.md) en los proyectos de biblioteca y de aplicación
7. Una solución `ProjectTemplate.sln` que referencia todos los proyectos de C# y facilita la compilación con [`dotnet build`](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build).
8. Tareas preconfiguradas para compilar y ejecutar los proyectos, ejecutar las pruebas, y generar documentación desde VSCode en la carpeta `.vscode`
9. Análisis de cobertura de los casos de prueba mediante []() que aparece en los márgenes con el complemento de VS Code [Coverage Gutters](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters).
10. Ejecución automática de compilación y prueba mediante [GitHub Actions](https://docs.github.com/en/actions) configuradas en el repositorio al hacer [push](https://github.com/git-guides/git-push) o [pull request](https://docs.github.com/en/github/collaborating-with-pull-requests).

Vean este 🎥 [video](https://web.microsoftstream.com/video/55c6a06c-07dc-4f95-a96d-768f198c9044) que explica el funcionamiento de la plantilla.

## Convenciones

[Convenciones de código en C#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

[Convenciones de nombres en C#](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

## Dónde encontrar información sobre los errores/avisos al compilar

[C# Compiler Errors (CS*)](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)

[Roslyn Analyzer Warnings (CA*)](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/categories)

[StyleCop Analyzer Warnings (SA*)](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)

# Cómo deshabilitar temporalmente los avisos al compilar

## Roslyn Analyzer

Comentar las siguientes líneas en los archivos de proyecto (`*.csproj`)
```
    <EnableNETAnalyzers>true</EnableNETAnalyzers>
    <AnalysisMode>AllEnabledByDefault</AnalysisMode>
    <EnforceCodeStyleInBuild>true</EnforceCodeStyleInBuild>
```

## StyleCop Analyzer

Comentar la línea `<PackageReference Include="StyleCop.Analyzers" Version="1.1.118"/>` en los archivos de proyecto (`*.csproj`)
>>>>>>> template/main
