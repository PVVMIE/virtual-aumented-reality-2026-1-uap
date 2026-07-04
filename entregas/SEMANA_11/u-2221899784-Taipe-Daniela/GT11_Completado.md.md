# Guía de Trabajo 11 — VR con Google Cardboard
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** TAIPE MONGE DANIELA YADIRA  **Código:** 2221899784
**Fecha:**20/06/2026 | **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (4 puntos)

**1.** Google Cardboard proporciona tracking de:
- [ ] a) 6DOF (posición + orientación)
- [x] b) 3DOF (solo orientación de la cabeza)
- [ ] c) Manos y controladores
- [ ] d) SLAM completo del entorno

**Explicación:** Cardboard solo detecta la orientación de la cabeza mediante sensores del celular, pero no el desplazamiento físico del usuario.

---

**2.** El "gaze" como método de interacción en VR Cardboard:
- [ ] a) Usa el micrófono para comandos de voz
- [x] b) Detecta hacia dónde mira el usuario con el head tracking
- [ ] c) Usa la pantalla táctil del celular
- [ ] d) Requiere un joystick Bluetooth

**Explicación:** El sistema utiliza la dirección de la mirada del usuario para interactuar con botones u objetos virtuales.

---

**3.** En el GazeCursor, `progressRing.fillAmount = tiempoMirando / tiempoActivacion` hace que:
- [ ] a) El anillo desaparezca al mirar un objeto
- [x] b) El anillo muestre el progreso circular de cuánto tiempo lleva mirando
- [ ] c) El objeto se mueva hacia la cámara
- [ ] d) Se calcule la distancia al objeto mirado

**Explicación:** El anillo se llena progresivamente mientras el usuario mantiene la mirada sobre un objeto hasta completar la activación.

---

**4.** La diferencia principal entre Cardboard y Meta Quest en términos de tracking es:
- [ ] a) Cardboard tiene mejor resolución
- [x] b) Meta Quest ofrece 6DOF (movimiento libre) vs Cardboard 3DOF (solo cabeza)
- [ ] c) Cardboard usa ARCore y Quest no
- [ ] d) No hay diferencia técnica

**Explicación:** Meta Quest permite desplazamiento libre y seguimiento espacial completo, mientras que Cardboard solo detecta movimientos de orientación.

---

## PARTE II — Completar (4 puntos)

1. En VR con Cardboard, la navegación principal sin controllers se hace por **gaze interaction** (mirar un objeto por N segundos).

2. El `Tracked Pose Driver` en la cámara hace que esta siga el **movimiento de la cabeza** del usuario en tiempo real.

3. Para crear el efecto de "mirar un portal y teletransportarse", se puede usar `Camera.main.transform.position` para reposicionar al usuario.

4. Un tour VR de 360° puede usar un **Skybox esférico** para envolver visualmente al usuario en una imagen esférica.

---

## PARTE III — Diseño (8 puntos)

### 3.1

| Punto de interés | Información mostrada al mirar | Tiempo de gaze |
|-----------------|------------------------------|---------------|
| Biblioteca | Horarios, salas de estudio y disponibilidad de libros | 2 s |
| Cafetería | Menú, precios y horarios de atención | 2 s |
| Laboratorios de cómputo | Software disponible y cursos relacionados | 2.5 s |
| Auditorio principal | Eventos académicos y conferencias | 2 s |
| Área deportiva | Deportes disponibles y horarios de entrenamiento | 2.5 s |

---

### 3.2

La navegación se implementaría mediante portales interactivos colocados en diferentes puntos del campus. El usuario tendría que mirar un portal durante algunos segundos para activarlo y ser teletransportado al siguiente espacio. También se podría incluir un menú flotante activado por gaze para seleccionar rápidamente cualquier ubicación del recorrido. Además, se utilizarían waypoints y señales luminosas para orientar al estudiante dentro del entorno virtual y facilitar la exploración del campus.

---

### 3.3

Las limitaciones que se deberían comunicar antes de usar el tour son:

1. Google Cardboard solo ofrece tracking 3DOF, por lo que no permite movimiento físico libre dentro del entorno virtual.  

2. El uso prolongado puede generar mareos, cansancio visual o incomodidad en algunos estudiantes debido a las limitaciones del dispositivo móvil.

---

## PARTE IV — Reflexión (4 puntos)

### 4.1

El “gaze time” no debe ser muy corto porque podrían activarse objetos accidentalmente cuando el usuario solo los mire por un instante. Tampoco debe ser muy largo porque la interacción se volvería lenta y frustrante. Un tiempo óptimo sería entre 1.5 y 2 segundos, ya que permite una experiencia cómoda, precisa y natural sin generar errores frecuentes ni cansancio en el usuario.

---

### 4.2

Mi grupo podría utilizar Google Cardboard para desarrollar un recorrido inmersivo de visualización arquitectónica o un tour interactivo del campus universitario. Técnicamente sí tiene sentido porque permite mostrar modelos 3D y recorridos virtuales utilizando solamente un celular y un visor económico. Esto facilitaría que más estudiantes puedan acceder a la experiencia VR sin necesidad de equipos costosos.

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
