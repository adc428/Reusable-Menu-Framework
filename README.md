# Project: Reusable Menu Framework in C# / .NET

# Description

This project implements a reusable hierarchical console menu framework in C#.  
The solution provides two independent implementations: one connects menu actions through an interface, and the other uses delegates and events.  
A console demo builds the same menu structure with both implementations and shows navigation, validation, and action execution.

# Components

Interface-Based Framework (`Ex04.Menus.Interfaces`):
Connects action items to objects that implement `IMenuAction.Execute()`.

Event-Based Framework (`Ex04.Menus.Events`):
Exposes an `Action` event on each action item so the application can subscribe handlers.

Root Menu (`MainMenu`):
Builds and displays the main menu and supports exit with option `0`.

Menu Model (`Menu`, `MenuItem`):
Stores menu entries, displays choices, validates input, and dispatches selected actions.

Nested Menus (`SubMenuItem`):
Support additional menu levels and return to the parent with option `0`.

Action Entries (`ActionMenuItem`):
Execute an interface action or raise an event when selected.

Console Renderer (`ConsoleMenuRenderer`):
Formats titles, choices, prompts, and validation messages.

Demo Application (`Ex04.Menus.Test`):
Builds both menu implementations and demonstrates date, time, version, and uppercase-count actions.

# Features

Two implementations of the same menu framework.

Hierarchical menus with reusable submenus and actions.

Menu actions separated from navigation logic.

Input validation for nonnumeric and out-of-range selections.

Exit and back navigation using option `0`.

Graceful handling of end-of-input and redirected console output.

Demo actions for the current date, current time, application version, and uppercase-letter counting.

# Files

## Solution and Projects
- `ReusableMenuFramework.sln`
- `Ex04.Menus.Interfaces/Ex04.Menus.Interfaces.csproj`
- `Ex04.Menus.Events/Ex04.Menus.Events.csproj`
- `Ex04.Menus.Test/Ex04.Menus.Test.csproj`

## Framework Source Files
Both framework folders include:
- `MainMenu.cs`
- `Menu.cs`, `MenuItem.cs`
- `SubMenuItem.cs`, `ActionMenuItem.cs`
- `ConsoleMenuRenderer.cs`

The interface-based folder also includes `IMenuAction.cs`.

## Demo Source Files
- `Program.cs`
- `InterfacesMenuBuilder.cs`, `EventsMenuBuilder.cs`
- `ShowCurrentDateAction.cs`, `ShowCurrentTimeAction.cs`
- `ShowVersionAction.cs`, `CountCapitalsAction.cs`

# Requirements

- .NET 9 SDK
- Visual Studio 2022 with .NET 9 support, or a terminal with the .NET SDK
- No external NuGet packages required

# How to Run

Open `ReusableMenuFramework.sln` in Visual Studio, set `Ex04.Menus.Test` as the startup project, and run it.

Alternatively, from the repository root:

```bash
dotnet build ReusableMenuFramework.sln -c Release
dotnet run --project Ex04.Menus.Test/Ex04.Menus.Test.csproj
```

The interface-based menu appears first. Enter `0` at its root to continue to the event-based menu. Enter `0` at the second root to end the program. Within a submenu, `0` returns to the parent.

# Notes

`Ex04.Menus.Test` is an interactive demonstration application, despite its project name.

The framework uses console menus; there are no graphical forms, external screen files, or data-file dependencies.

This coursework project demonstrates abstraction, inheritance, interfaces, delegates, events, and loose coupling.
