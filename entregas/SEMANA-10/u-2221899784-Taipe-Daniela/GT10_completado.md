# Guía de Trabajo 10 — Interacción Avanzada en AR
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** TAIPE MONGE DANIELA YADIRA  **Código:** 2221899784
**Fecha:** 13/06/2026| **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (4 puntos)

1. Para evitar conflicto entre pinch (2 dedos) y rotate (1 dedo), se debe:
- [ ] a) Deshabilitar uno de los dos gestos
- [x] b) Usar if (touchCount == 2) para pinch y else if (touchCount == 1) para rotate
- [ ] c) Usar callbacks en vez de Update()
- [ ] d) Cada gesto requiere un script separado

Explicación:
Al verificar primero si hay dos dedos y luego un dedo mediante else if, se evita que ambos gestos se ejecuten al mismo tiempo y generen conflictos en la interacción.


2. Un Canvas con Render Mode "World Space" en AR permite:
- [ ] a) Que la UI siempre esté en la misma posición de la pantalla
- [x] b) Que la UI exista como objeto 3D flotante en el espacio AR
- [ ] c) Que la UI sea transparente
- [ ] d) Optimizar automáticamente el número de draw calls

Explicación:
El modo World Space convierte la interfaz en un objeto dentro del entorno 3D, permitiendo que el usuario la vea integrada en el espacio aumentado.


3. Physics.Raycast en este contexto (S10) detecta:
- [ ] a) Planos AR detectados por ARCore
- [x] b) Colliders de GameObjects de Unity
- [ ] c) Feature points del SLAM
- [ ] d) La posición de la luz en la escena

Explicación:
Physics.Raycast lanza un rayo virtual para detectar colisiones con GameObjects que poseen componentes Collider dentro de Unity.


4. LookAt(Camera.main.transform) aplicado a un panel UI:
- [ ] a) Hace que el panel se mueva hacia la cámara
- [x] b) Rota el panel para que siempre enfrente a la cámara (billboard)
- [ ] c) Cambia el tamaño del panel según la distancia
- [ ] d) Desactiva el panel cuando la cámara se aleja

Explicación:
La función LookAt orienta el objeto hacia la cámara, permitiendo que el usuario siempre pueda leer el contenido del panel sin importar su posición.


## PARTE II — Completar (4 puntos)

1. t.deltaPosition.x en un Touch de Unity indica el DESPLAZAMIENTO del dedo desde el frame anterior en el eje horizontal.

2. Mathf.Clamp(valor, min, max) en el pinch sirve para LIMITAR los valores de escala extremos.

3. Para mostrar datos de una API REST en Unity, se usa una COROUTINE (método que puede pausar sin bloquear el hilo principal).

4. Un panel UI que siempre mira a la cámara se llama BILLBOARD en diseño 3D.


## PARTE III — Análisis y diseño (8 puntos)

### 3.1 Analiza el fragmento de código

| Sección | ¿Qué hace? | ¿Cuándo se activa? |
|----------|------------|-------------------|
| A | Detecta dos dedos y calcula la distancia entre ellos para realizar escalado (pinch) | Cuando Input.touchCount == 2 |
| B | Detecta el movimiento horizontal de un dedo y rota el objeto | Cuando Input.touchCount == 1 y el dedo se mueve |
| Else-if | Evita que el sistema procese pinch y rotación simultáneamente | Cuando solo existe un dedo en pantalla |


### 3.2 Pseudo-código del sistema de interacción

```pseudo
Iniciar aplicación

Si usuario toca un plano AR:
    Crear sofá en la posición detectada

Si hay 2 dedos en pantalla:
    Calcular distancia entre dedos
    Escalar sofá según la variación de distancia
    Limitar escala con Clamp()

Si hay 1 dedo en pantalla:
    Detectar movimiento horizontal
    Rotar sofá sobre eje Y

Si usuario toca el sofá:
    Mostrar panel UI con:
        - Nombre del producto
        - Precio
        - Descripción
```


### 3.3 Diferencia entre Physics.Raycast y ARRaycastManager.Raycast

| | Physics.Raycast | ARRaycastManager.Raycast |
|---|---|---|
| Detecta | Colliders de GameObjects de Unity | Planos y superficies detectadas por ARCore/ARKit |
| Cuándo usar | Seleccionar o interactuar con objetos virtuales | Colocar objetos AR sobre superficies reales |


## PARTE IV — Reflexión (4 puntos)

### 4.1 Affordance visual en una app AR

1. Resaltar el sofá con un borde luminoso cuando el usuario lo apunta o toca, indicando que es interactivo.

2. Mostrar iconos flotantes de rotación y escalado alrededor del sofá para sugerir que puede manipularse con gestos.


### 4.2 Adaptaciones para usuarios mayores de 60 años

1. Utilizar botones grandes y textos con mayor tamaño para facilitar la lectura.

2. Reducir la cantidad de gestos complejos, permitiendo acciones mediante botones visibles.

3. Incorporar instrucciones visuales y mensajes de ayuda permanentes durante el uso de la aplicación.

4. Aumentar el contraste de colores para mejorar la visibilidad de la interfaz.


Conclusión:

La aplicación AR debe gestionar correctamente los gestos táctiles para evitar conflictos entre escalado y rotación. Además, el uso de interfaces intuitivas, affordance visual y adaptaciones para adultos mayores mejora significativamente la experiencia de usuario y la accesibilidad de la aplicación.

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
