VfxExtra
========

**VfxExtra** is a collection of utilities for Unity Visual Effect Graph.

At the moment, it only contains property/event binder classes for the new Input
System.

![screenshot](https://i.imgur.com/HHfxX5dm.jpg)

### Property binders

**VFXInputValueBinder** -- Binds a value (axis, button pressure, etc.) of an
InputAction to a VFX property.

**VFXPlayerInputValueBinder** -- Retrieves a value of an action from a
PlayerInput and binds it to a VFX property.

### Event binders

**VFXInputEventBinder** -- Sends a VFX event on an InputAction.

**VFXPlayerInputEventBinder** -- Receives an action from a PlayerInput and
sends a VFX event.
