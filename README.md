
# Interfaces Inteligentes - P01 Introducción a Unity
## José Daniel Escánez Expósito

Se ha realizado una escena 3D básica utilizando exclusivamente el editor de escenas.
Esta cumple los requisitos exigidos en el enunciado de la práctica, configurándose de la siguiente manera:

- Incluye objetos 3D básicos (un cubo y una esfera)
- Incluye algún objeto complejo de Standard Assets (un coche)
- Incluye un objeto libre de la Asset Store que no es de los Standard Assets (dos tipos de montañas)
- Ha sido creado un terreno, al que se le aplicaron texturas y relieves
- Cada objeto tiene una etiqueta que lo identifica
- La escena tiene 2 fuentes de luz: la directional light generada por defecto, a la que se le aplicó una reducción en la intensidad; y una spotlight anclada al personaje, imitando una linterna
- Utiliza el prefab de standard assets para un FPS
- Se ha agregado un script que escribe en la consola los objetos que se han utilizado, un identificador numérico asignado a cada uno de los objetos y el valor de un contador que se actualiza en cada iteración para cada objeto

Script desarrollado `script.cs`:
```cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
  int iterations = 0;
  public int id;
  // Update is called once per frame
  void Update() {
    Debug.Log(System.String.Format("Tag: {0}, Id: {1}, Iterations: {2}",
        gameObject.tag, id, iterations++));
  }
}

```

En este gif se puede revisar el correcto funcionamiento de lo indicado anteriormente:

![Gif ilustrativo del correcto funcionamiento de la escena creada](gifEscena3d.gif)

