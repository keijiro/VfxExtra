VfxExtra
========

**VfxExtra** is a collection of utilities for Unity Visual Effect Graph.

At the moment, it only contains property/event binder classes for the [new
Input System].

[new Input System]:
    https://blogs.unity3d.com/2019/10/14/introducing-the-new-input-system/

![screenshot](https://i.imgur.com/HHfxX5dm.jpg)

### Property binders

VFXInputValueBinder -- Binds a value (axis, button pressure, etc.) of an
InputAction to a VFX property.

VFXPlayerInputValueBinder -- Retrieves a value of an action from a PlayerInput
and binds it to a VFX property.

### Event binders

VFXInputEventBinder -- Sends a VFX event on an InputAction.

VFXPlayerInputEventBinder -- Receives an action from a PlayerInput and sends a
VFX event.

## How to install

[Follow those instructions] to set up the scoped registry. Then, you can install
the VfxExtra package via Package Manager.

[Follow those instructions]:
  https://gist.github.com/keijiro/f8c7e8ff29bfe63d86b888901b82644c
