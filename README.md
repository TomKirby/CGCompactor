# CGCompactor
Take a c# solution of bot source code, and compact it into a single `.cs` file for submitting to Codingame.

## Configuration:
editing the app.config file allows the following values to be changed:
```
  <appSettings>
    <add key="solutionPath" value="C:\PERSONAL\DEV\Codingame\StarterBot"/>
    <add key="exclusionDirectories" value="obj,TestSrc"/>
  </appSettings>
```

- **solutionPath** - The path to your bots source code.
- **exclusionDirectories** - A comma seperated list of directory names to exclude from the file import. `obj` & `.vs` prevents redundant files being included, `TestSrc` is an example of a directory which may contain unit test files you do not wish to include in your final output.

## Reporting issues
Although this project is only intended as a quick tool thrown together to aid in bot development, please feel free to submit PR's and file any blatent issues.. In reality, its pretty simple and will likly just act as a base for your own development of a tool.