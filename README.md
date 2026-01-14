# Obstacle Dodge

This repository is my implementation of the "Object Dodge" tutorial project from the Udemy course: "Complete C# Unity 3D Game Development in Unity 6".

## Summary

It's a simple Unity project where the player moves an object and must dodge falling/traveling obstacles. This repo is a learning/example project that reproduces the tutorial exercises and demonstrates basic Unity concepts:
- movement
- collisions
- simple scoring
- enabling/disabling physics behaviors
- dynamic tagging.

## Unity version

Built on Unity version (from `ProjectSettings/ProjectVersion.txt`):

```
m_EditorVersion: 6000.3.3f1
m_EditorVersionWithRevision: 6000.3.3f1 (ef04196de0d6)
```

Use Unity Editor 6.x (the same channel/build) when opening this project for best compatibility.

## Requirements / Packages

- The project uses Unity's built-in input axes (`Input.GetAxis("Horizontal")` / `Input.GetAxis("Vertical")`) for player movement (WASD or Arrow keys).
- There is an `Assets/InputSystem_Actions.inputactions` file included; however the current movement script uses the legacy Input API. If you intend to use the new Input System package, wire those actions up and update the movement code.
- Project settings include URP configuration (`ProjectSettings/URPProjectSettings.asset`) — you may need the Universal RP package installed to match rendering settings. If you open the project and see package-related warnings, open Window > Package Manager and install the missing packages (Input System, Universal RP) as needed.

## Controls

- Movement: WASD or Arrow keys (mapped to the `Horizontal` and `Vertical` axes via Unity's Input Manager).

## Scripts (brief)

The main gameplay scripts are in `Assets/Scripts/`:

- `Mover.cs` — Handles player movement. Uses `Input.GetAxis("Horizontal")` and `Input.GetAxis("Vertical")` to move the GameObject. Logs simple instructions to the console in `Start()`.
- `Dropper.cs` — Hides meshes and disables gravity initially; after a configurable delay it enables the mesh renderer and gravity so objects drop into the scene.
- `ObjectHit.cs` — When the player collides with an object carrying this script, the object changes color to red and its tag is set to `Hit`.
- `Scorer.cs` — Tracks score: increments when the player collides with objects that haven't already been marked as `Hit` and logs the count to the console.

These scripts are intentionally small and focused to match the tutorial's learning scope.