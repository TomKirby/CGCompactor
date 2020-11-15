# CGCompactor
A tool intended to take a directory of c# source code files(usually a project or number of projects in a solution) and compact them into a single c# file which can then be copied and pasted for into the online editor for sites like Codingame.com.

## Configuration:
editing the app.config file allows the following values to be changed:
```
  <appSettings>
    <add key="solutionPath" value="C:\PERSONAL\DEV\Codingame\StarterBot"/>
    <add key="exclusionDirectories" value=".vs,obj,TestSrc"/>
  </appSettings>
```

- **solutionPath** - The path to your bots source code.
- **exclusionDirectories** - A comma separated list of directory names to exclude from the file import. `obj` & `.vs` prevents redundant files being included, `TestSrc` is an example of a directory which may contain unit test files you do not wish to include in your final output.

## Reporting issues
Although this project is only intended as a quick tool thrown together to aid in bot development, please feel free to submit PR's and file any blatant issues... In reality, it is pretty simple and will likely act as a base for the development of your own tooling.