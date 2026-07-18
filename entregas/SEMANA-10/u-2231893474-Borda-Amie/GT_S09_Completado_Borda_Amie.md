# Guía de Trabajo 10 — Interacción Avanzada en AR
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** Borda Garcia, Amie Paola **Código:** 2231893474
**Fecha:** 18/07/2026 | **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (4 puntos)

**1.** Para evitar conflicto entre pinch (2 dedos) y rotate (1 dedo), se debe:
- [ ] a) Deshabilitar uno de los dos gestos
- [x ] b) Usar `if (touchCount == 2)` para pinch y `else if (touchCount == 1)` para rotate
- [ ] c) Usar callbacks en vez de Update()
- [ ] d) Cada gesto requiere un script separado

**2.** Un Canvas con Render Mode "World Space" en AR permite:
- [ ] a) Que la UI siempre esté en la misma posición de la pantalla
- [ x] b) Que la UI exista como objeto 3D flotante en el espacio AR
- [ ] c) Que la UI sea transparente
- [ ] d) Optimizar automáticamente el número de draw calls

**3.** `Physics.Raycast` en este contexto (S10) detecta:
- [ ] a) Planos AR detectados por ARCore
- [x ] b) Colliders de GameObjects de Unity
- [ ] c) Feature points del SLAM
- [ ] d) La posición de la luz en la escena

**4.** `LookAt(Camera.main.transform)` aplicado a un panel UI:
- [ ] a) Hace que el panel se mueva hacia la cámara
- [ x] b) Rota el panel para que siempre enfrente a la cámara (billboard)
- [ ] c) Cambia el tamaño del panel según la distancia
- [ ] d) Desactiva el panel cuando la cámara se aleja

---

## PARTE II — Completar (4 puntos)

1. `t.deltaPosition.x` en un Touch de Unity indica desplazamiento del dedo desde el frame anterior en el eje horizontal.

2. `Mathf.Clamp(valor, min, max)` en el pinch sirve para limitar los valores de escala extremos.

3. Para mostrar datos de una API REST en Unity, se usa una Corrutina (método que puede pausar sin bloquear el hilo principal).

4. Un panel UI que siempre mira a la cámara se llama Billboard en diseño 3D.

---

## PARTE III — Análisis y diseño (8 puntos)

**3.1** (3 pt) Analiza este fragmento de código e identifica qué hace cada sección:

```csharp
void Update()
{
    // SECCIÓN A
    if (Input.touchCount == 2)
    {
        Touch t0 = Input.GetTouch(0);
        Touch t1 = Input.GetTouch(1);
        float dist = Vector2.Distance(t0.position, t1.position);
        // ... escalar
    }
    
    // SECCIÓN B
    else if (Input.touchCount == 1)
    {
        Touch t = Input.GetTouch(0);
        if (t.phase == TouchPhase.Moved)
        {
            objeto.transform.Rotate(Vector3.up, -t.deltaPosition.x * 0.3f, Space.World);
        }
    }
}
```

| Sección | ¿Qué hace? | ¿Cuándo se activa? |
|---------|-----------|------------------|
| A |Calcula la distancia entre dos toques para cambiar el tamaño del objeto (Pinch-to-zoom). |Cuando el usuario tiene exactamente 2 dedos tocando la pantalla al mismo tiempo. |
| B |Gira el objeto en su eje vertical (Y) basándose en el movimiento horizontal del toque. |Cuando el usuario tiene exactamente 1 dedo tocando la pantalla y está en movimiento (Moved). |
| Else-if |Garantiza exclusividad mutua, separando la lógica de rotación y escala para evitar errores. |Cuando la condición A es falsa (no hay 2 dedos) y sí se cumple que hay exactamente 1 dedo. |

**3.2** (3 pt) Diseña en pseudo-código el sistema de interacción para una app AR de compras donde el usuario puede:
- Colocar un sofá en la sala (tap en plano)
- Escalarlo con pinch
- Rotarlo con dedo
- Ver precio al tocar el sofá

```
// Pseudo-código del sistema de interacción:
SI hay toques en pantalla:
    SI (Cantidad de dedos == 1):
        Obtener toque(0)
        
        SI (toque está en fase "Began"):
            Lanzar Physics Raycast hacia objetos 3D
            SI (Golpea el Sofá):
                Mostrar Panel UI flotante con el PRECIO
            SINO:
                Lanzar AR Raycast hacia Planos Reales
                SI (Golpea un Plano AR y el Sofá NO existe aún):
                    Instanciar el Sofá en la posición del plano impactado
                    
        SI (toque está en fase "Moved" Y el Sofá ya existe):
            Rotar Sofá en el eje Y dependiendo de la dirección X del toque (deltaPosition.x)
            
    SI (Cantidad de dedos == 2 Y el Sofá ya existe):
        Obtener distancia actual entre los 2 dedos
        Obtener distancia anterior entre los 2 dedos (frame pasado)
        Calcular diferencia de distancia
        Escalar el Sofá usando Mathf.Clamp para limitar tamaño mínimo/máximo



```

**3.3** (2 pt) ¿Cuál es la diferencia entre Physics.Raycast y ARRaycastManager.Raycast? ¿Cuándo se usa cada uno?

| | Physics.Raycast | ARRaycastManager.Raycast |
|--|----------------|------------------------|
| Detecta |Mallas con Colliders virtuales |Superficies del mundo real |
| Cuándo usar |Para interactuar con objetos virtuales instanciados |Para ubicar/instanciar objetos reconociendo el piso, mesa o pared física. |

---

## PARTE IV — Reflexión (4 puntos)

**4.1** (2 pt) El principio de "affordance" en UX significa que el objeto debe parecer interactivo sin necesidad de instrucciones. Propón 2 formas de aplicar affordance visual en tu app AR de proyecto.

> Aplicar un contorno brillante (Outline shader) alrededor del modelo 3D al instanciarlo para que el usuario intuya que es interactivo y puede tocarlo.
> Agregar una animación suave de rotación (Idle) o colocar debajo un proyector tipo anillo que funcione como "base" visual.

**4.2** (2 pt) Si tu app AR es para usuarios mayores de 60 años (adultos mayores), ¿qué cambios harías en la interacción? Menciona al menos 3 adaptaciones.

> Reemplazar los gestos complejos como el "Pinch-to-zoom" por botones UI clásicos de [+] y [-] que siempre estén visibles en pantalla.
> Aumentar el tamaño de los textos, usar alto contraste en la UI y asegurar que los paneles floten usando Billboarding para que siempre los vean de frente sin esfuerzo.
> Agregar feedback multisensorial: al tocar un objeto, emitir un sonido claro y activar una pequeña vibración (Haptic Feedback) para confirmar la acción de forma notoria.

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
