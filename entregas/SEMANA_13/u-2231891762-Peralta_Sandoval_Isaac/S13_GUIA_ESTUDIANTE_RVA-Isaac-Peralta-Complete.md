# S13 — GUÍA DE TRABAJO DEL ESTUDIANTE
## Curso: Realidad Virtual y Aumentada | PSISP08075
### Semana 13 — Accesibilidad en RA y RV

---

> **Instrucciones generales**
> - Esta guía tiene 4 secciones (A, B, C, D) de complejidad creciente.
> - No hay respuestas en este documento — las encontrarás por tu propio análisis.
> - En la sección A y B: solo una respuesta es correcta.
> - En la sección C y D: se valora la profundidad del análisis y la creatividad.
> - Tiempo estimado: 90–120 minutos.

---

## SECCIÓN A — OPCIÓN MÚLTIPLE (25 puntos, 2.5 pts c/u)

**Instrucción:** Marca con una X la única respuesta correcta para cada pregunta.

---

**A1.** Según el modelo social de la discapacidad, cuando un usuario en silla de ruedas no puede usar una app de VR que requiere ponerse de pie para alcanzar objetos, el problema principal es:

- [ ] a) La condición médica del usuario que le impide ponerse de pie
- [X] b) El diseño de la app que no consideró usuarios con movilidad reducida
- [ ] c) La tecnología VR que todavía no está madura para casos especiales
- [ ] d) El usuario, quien debería usar una versión diferente de la app para discapacitados

---

**A2.** ¿Cuál es el ratio de contraste mínimo que exige WCAG 2.1 nivel AA para texto normal sobre fondo?

- [ ] a) 2:1
- [ ] b) 3:1
- [X] c) 4.5:1
- [ ] d) 7:1

---

**A3.** Un usuario con **daltonismo rojo-verde (deuteranopia)** usa tu app AR de medicina donde el color rojo indica tejido dañado y verde indica tejido sano. ¿Cuál es la solución de accesibilidad más completa?

- [ ] a) Eliminar todos los colores rojo y verde de la app y usar solo escala de grises
- [ ] b) Agregar un modo especial "para daltónicos" con colores diferentes
- [X] c) Mantener los colores pero añadir forma, icono de advertencia y texto overlay como canales adicionales de información
- [ ] d) Informar al usuario que la app no es compatible con daltonismo en los términos de servicio

---

**A4.** La técnica "Dwell Time" en VR/AR permite:

- [ ] a) Ajustar el tiempo de renderizado de frames para mejorar rendimiento
- [X] b) Seleccionar objetos simplemente mirándolos durante un tiempo configurado, sin usar las manos
- [ ] c) Medir cuánto tiempo el usuario pasa dentro de una sesión VR
- [ ] d) Controlar la velocidad de locomoción para reducir cybersickness

---

**A5.** ¿Por qué el texto AR sobre fondo transparente es particularmente problemático para personas con baja visión?

- [ ] a) Porque el rendering de texto transparente consume más GPU
- [ ] b) Porque el texto flotante parece falso y rompe la ilusión de realidad
- [X] c) Porque el fondo del mundo real es variable e impredecible, haciendo imposible garantizar contraste suficiente
- [ ] d) Porque el texto AR requiere un shader especial incompatible con la mayoría de dispositivos

---

**A6.** El **cybersickness** se produce principalmente por:

- [ ] a) La calidad baja de los gráficos en entornos VR económicos
- [X] b) Una discordancia entre la información visual (movimiento en VR) y la información vestibular (el cuerpo no se mueve)
- [ ] c) La duración excesiva de la sesión VR sin descanso
- [ ] d) El peso del headset que causa fatiga en el cuello

---

**A7.** ¿Qué es el documento **XAUR** (XR Accessibility User Requirements)?

- [ ] a) Un SDK de Unity para implementar accesibilidad en proyectos XR
- [X] b) La extensión de WCAG publicada por el W3C para definir requisitos de accesibilidad específicos para XR
- [ ] c) El estándar legal obligatorio de accesibilidad XR en la Unión Europea
- [ ] d) Una herramienta de diagnóstico de accesibilidad para headsets Meta Quest

---

**A8.** En el script `SubtitulosXR.cs` visto en clase, el método se coloca en `LateUpdate()` en lugar de `Update()` porque:

- [ ] a) `LateUpdate()` es más eficiente en términos de memoria para cálculos de UI
- [X] b) `LateUpdate()` se ejecuta después de que la cámara se ha movido, garantizando que los subtítulos se posicionen correctamente respecto a la posición final de la cámara en ese frame
- [ ] c) `LateUpdate()` es el único ciclo de vida que permite modificar transformaciones en VR
- [ ] d) `Update()` no puede acceder a la posición de la cámara, solo `LateUpdate()` puede

---

**A9.** El "efecto bordillo" (curb cut effect) en diseño accesible se refiere a:

- [ ] a) La necesidad de añadir rampas en todas las entradas de edificios
- [X] b) El principio de que las soluciones diseñadas para personas con discapacidad terminan beneficiando a todos los usuarios
- [ ] c) La técnica de diseño que coloca todos los elementos de UI cerca del borde inferior de la pantalla
- [ ] d) El problema de la fatiga de brazo cuando los menús están muy separados en VR

---

**A10.** ¿Cuál es la diferencia clave entre **locomoción libre** y **teleportación** en VR desde el punto de vista de la accesibilidad?

- [ ] a) La teleportación es más difícil de implementar y solo se usa en apps avanzadas
- [ ] b) La locomoción libre permite moverse más rápido y es preferida por usuarios profesionales
- [X] c) La locomoción libre con joystick puede causar cybersickness ya que el cuerpo no se mueve físicamente, mientras la teleportación elimina esa discordancia
- [ ] d) No hay diferencia significativa en accesibilidad, solo en la sensación de inmersión

---

## SECCIÓN B — COMPLETAR Y RELACIONAR (22 puntos)

### B1 — Completar espacios en blanco (12 puntos, 2 pts c/u)

Completa correctamente cada espacio:

1. WCAG son las siglas de **_Web Content Accessibility Guidelines_** y sus cuatro principios (POUR) son: Perceptible, **_Operable_**, Comprensible y Robusto.

2. El componente de Unity que permite asignar una etiqueta accesible y descripción a cualquier GameObject para que el lector de pantalla del sistema operativo los pueda leer se llama **_Unity Accessibility Plugin_**.

3. El **_cybersickness_** es el conjunto de síntomas de náusea, desorientación y malestar causado por la discordancia entre la información visual del entorno VR y las señales del sistema vestibular.

4. Para que el texto en AR sea legible independientemente del fondo del mundo real, se debe añadir un **_fondo (background)_** semiopaco detrás del texto.

5. Según WCAG 2.1, las imágenes o elementos que contienen información no deben usar **_color_** como único medio de transmitir esa información — deben incluir también forma, patrón o texto.

6. La organización que publicó el documento XAUR (XR Accessibility User Requirements) es el **_W3C_**.

---

### B2 — Relacionar columnas (10 puntos, 1 pt c/u)

Conecta cada barrera de accesibilidad (columna izquierda) con su solución más apropiada en XR (columna derecha):

| # | Barrera de accesibilidad | Letra | Solución en XR |
|---|--------------------------|-------|----------------|
| 1 | Usuario sordo no puede escuchar narración de audio en VR | C | A. Backing panel semiopaco + texto outline |
| 2 | Usuario con daltonismo no distingue zonas de peligro codificadas en rojo | D | B. Dwell time (selección por mirada con tiempo configurable) |
| 3 | Texto AR ilegible sobre fondos claros del mundo real | A | C. Subtítulos 3D anclados a la cámara (head-locked) |
| 4 | Usuario con Parkinson no puede presionar botones pequeños del controller | F | D. Iconos de forma + texto "PELIGRO" redundante al color |
| 5 | Primera vez en VR — usuario adulto mayor siente náuseas con joystick | E | E. Modo teleportación + vignette dinámico + velocidad ajustable |
| 6 | Usuario con autismo siente sobrecarga sensorial con muchos estímulos | G | F. Botones más grandes + zona de toque ampliada + modo hold |
| 7 | Usuario en silla de ruedas no puede alcanzar objetos colocados muy arriba en VR | H | G. Modo calma: reducir objetos, sonidos y velocidad |
| 8 | App sin modo pausa: usuario con epilepsia expuesto a flashes continuos | J | H. Reposicionar UI dentro del rango de movimiento sentado |
| 9 | App de entrenamiento VR usa solo audio para dar feedback de errores | I | I. Semáforos, iconos y vibración como canales adicionales |
| 10 | Usuario ciego quiere explorar objetos 3D en un museo VR | K | J. Máximo flash rate configurado + botón de pausa siempre visible |
| | | | K. Audio descriptivo espacial + hápticos de confirmación |

---

## SECCIÓN C — ANÁLISIS Y DIAGNÓSTICO (28 puntos)

### C1 — Diagnóstico de código con problemas de accesibilidad (12 puntos)

El siguiente script de Unity fue escrito sin considerar accesibilidad. Identifica **al menos 4 problemas concretos de accesibilidad** y para cada uno propón la solución correcta.

```csharp
using UnityEngine;
using UnityEngine.UI;

public class MenuPrincipalVR : MonoBehaviour
{
    public Button botonIniciar;
    public Button botonOpciones;
    public Button botonSalir;
    public Image imagenEstado;  // Rojo = error, Verde = OK
    public AudioSource alarma;  // Sonido de alerta de error

    void Start()
    {
        // Colores de estado
        imagenEstado.color = Color.green;

        // Tamaño fijo de botones
        botonIniciar.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 25);
        botonOpciones.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 25);
        botonSalir.GetComponent<RectTransform>().sizeDelta = new Vector2(80, 25);

        // Timeout automático sin aviso
        Invoke("CerrarSesion", 60f);
    }

    void Update()
    {
        // Animación de parpadeo del estado
        float velocidadParpadeo = 8f;  // 8 ciclos por segundo
        float alpha = Mathf.Abs(Mathf.Sin(Time.time * velocidadParpadeo * Mathf.PI));
        imagenEstado.color = new Color(imagenEstado.color.r,
                                        imagenEstado.color.g,
                                        imagenEstado.color.b, alpha);
    }

    public void MostrarError()
    {
        imagenEstado.color = Color.red;
        alarma.Play();
        // No hay feedback de texto — solo color y sonido
    }

    void CerrarSesion()
    {
        Application.Quit();
    }
}
```

Para cada problema, usa esta tabla:

| # | Línea(s) | Problema de accesibilidad | Tipo de discapacidad afectada | Solución correcta |
|---|----------|--------------------------|-------------------------------|-------------------|
| 1 | 167,194-199 | Dependencia exclusiva del color y el audio. El método MostrarError solo cambia la imagen a rojo y reproduce un sonido, sin ofrecer texto descriptivo de lo que falló. | Visual (Ceguera, daltonismo) y Auditiva (Sordera). | Añadir un componente TMPro.TextMeshProUGUI para mostrar un mensaje de texto claro del error (ej. "Error: Conexión perdida"). Asegurar que la UI use un lector de pantalla o mande un evento háptico al control. |
| 2 | 176-178 | Botones con tamaño fijo extremadamente pequeño. Forzar un sizeDelta de (80, 25) en VR crea áreas de interacción diminutas (hitboxes estrechas), lo que dificulta mucho apuntar con los controladores de movimiento. | Motriz (Temblores, Parkinson, movilidad reducida). | Eliminar el escalado estático por código. Permitir tamaños dinámicos/grandes mediante el inspector y ampliar el Collider o área de toque (Target Graphic) para facilitar la selección. |
| 3 | 181,201-204 | Cierre de sesión automático (Timeout) sin advertencia ni opción a prórroga. Expulsar al usuario de golpe tras 60 segundos rompe el criterio de WCAG sobre control de tiempo. | Cognitiva (Procesamiento lento, dislexia) y Motriz. | Implementar un sistema de aviso previo (ej. a los 45s) mediante un pop-up que pregunte "¿Sigues ahí?" y permita al usuario extender el tiempo con un botón antes de cerrar la sesión. |
| 4 | 184-192 | Parpadeo de UI a alta frecuencia fija. Una velocidad de parpadeo de 8Hz (8 ciclos por segundo) está dentro del rango crítico (entre 3Hz y 50Hz) capaz de inducir crisis fotosensibles. | Neurológica (Epilepsia fotosensible). | Reducir la frecuencia del parpadeo por debajo de los 2Hz o, idealmente, eliminar el parpadeo cíclico del canal alpha. Utilizar animaciones de transición suaves o un cambio de icono estático. |

---

### C2 — Comparación: Audio Narration vs Spatial Audio Descriptions (8 puntos)

Explica la diferencia entre estos dos enfoques para hacer una app VR accesible a usuarios ciegos:

**Enfoque A:** La app tiene una narración lineal de audio que describe todo el contenido de la escena al inicio de cada nivel — el usuario escucha una descripción completa en 2 minutos y luego navega libremente.

**Enfoque B:** La app usa "audio descriptions espaciales" — cuando el usuario gira la cabeza o se aproxima a un objeto, el sistema dice en voz alta el nombre, función y estado de ese objeto específico.

Responde:
1. ¿Cuál enfoque representa mejor el modelo social de la discapacidad? Justifica.
Enfoque B, el modelo social busca adaptar el entorno para otorgar autonomía. El enfoque B permite al usuario explorar el espacio tridimensional a su propio ritmo e interactuar de forma equivalente a un usuario normovidente, en lugar de obligarlo a consumir contenido de forma pasiva y segregada.
2. ¿Qué limitaciones tiene el Enfoque A que el Enfoque B no tiene?
- Sobrecarga cognitiva inicial: Memorizar 2 minutos de datos espaciales antes de jugar es difícil.
- Falta de dinamismo: Si el entorno cambia o los objetos se mueven, la narración inicial queda obsoleta.
- Pérdida de la presencia VR: Convierte una experiencia inmersiva e interactiva en un audiolibro estático.
3. ¿En qué tipo de app VR el Enfoque A sería más apropiado que el B?
En experiencias puramente cinematográficas, narrativas lineales, cinemáticas de introducción o visitas virtuales guiadas donde el usuario no tiene control ni libertad de movimiento y el progreso es fijo.
4. ¿Cómo implementarías el Enfoque B en Unity a nivel técnico (qué componente y evento usarías)?
- Componentes: un AudioSource en cada objeto interactivo configurado con un Spatial Blend en 1.0 (3D total) para que el sonido provenga del lugar real del objeto. Además, un Collider configurado como Trigger en el objeto o un sistema de Raycasting desde la cámara (cabeza del usuario).
- Eventos: utilizaría los eventos OnTriggerEnter() (cuando el usuario se aproxima) u OnPointerEnter() / OnHoverEntered() de las librerías XR (cuando el usuario lo mira directamente) para disparar el archivo de audio descriptivo o el motor de texto a voz (TTS).
---

### C3 — Caso: App de rehabilitación física en VR (8 puntos)

Una empresa de Lima está desarrollando una app de **rehabilitación física en VR** para pacientes post-operados en hospitales peruanos. La app pide a los pacientes hacer movimientos específicos de brazos para recuperar rango de movimiento (cirugía de hombro, codo, muñeca). El headset es un Meta Quest 3.

El equipo identificó estos usuarios objetivo:
- Paciente A: mujer de 65 años, primera vez con VR, operada del hombro derecho
- Paciente B: hombre de 45 años, usa VR ocasionalmente, con parálisis parcial de mano derecha por accidente
- Paciente C: joven de 22 años, experiencia en videojuegos, sordo desde nacimiento
- Paciente D: hombre de 55 años, con daltonismo rojo-verde, operado de ambos codos

Para cada paciente:
1. Identifica las 2 principales barreras de accesibilidad que encontraría en una app diseñada sin accesibilidad
2. Propón 1 solución concreta de diseño XR para cada barrera

**Formato de respuesta:**

| Paciente | Barrera 1 | Solución 1 | Barrera 2 | Solución 2 |
|----------|-----------|-----------|-----------|-----------|
| A (65 años, cirugía hombro) | Fatiga motriz y dolor al levantar el brazo derecho para interactuar. | Modo zurdo / Espejo: Permitir transferir toda la UI e interacciones principales al brazo izquierdo sano. | Cybersickness / Desorientación por ser usuaria primeriza. | Teleportación y viñeta estricta: Movimiento por saltos e inclusión de un horizonte fijo o jaula virtual para evitar mareos. |
| B (parálisis mano derecha) | Imposibilidad de pulsar botones o gatillos físicos del controlador derecho. | Dwell Time o Gestos: Permitir selección manteniendo la mirada, o mediante Hand Tracking usando solo la mano izquierda. | Falta de agarre continuo de objetos virtuales en los ejercicios. | Modo Toggle de agarre: Un solo clic para agarrar y otro para soltar, eliminando la necesidad de mantener presionado el botón. |
| C (sordo, 22 años)  | Incapacidad de escuchar indicaciones u órdenes del terapeuta virtual en audio. | Subtítulos 3D + Indicadores visuales: Subtítulos anclados a la cámara y flechas direccionales que apunten al objetivo. | Pérdida de feedback sonoro al realizar correctamente un ejercicio. | Hápticos y efectos visuales: Vibración del control y destellos de luz (e.g., partículas verdes) al completar una repetición. |
| D (daltonismo, codos) | Confusión de elementos de UI basados solo en código de colores (rojo/verde). | Doble codificación: Añadir iconos claros (un check para "correcto" y una equis para "error") junto con texto redundante. | Limitación para estirar los brazos o alcanzar elementos lejanos. | Imán virtual / Puntero láser: Permitir atraer objetos lejanos con solo apuntar, sin requerir extensión completa del codo. |

---

## SECCIÓN D — CASO AVANZADO (25 puntos)

### Caso: Sistema XR de Educación Inclusiva para Zonas Rurales del Perú

El **Programa Nacional de Innovación Educativa** contrata a tu equipo para desarrollar un sistema XR educativo para colegios de zonas rurales de Ayacucho y Huancavelica. Las características del contexto:

- Estudiantes de 12-17 años con diversidad de capacidades
- Algunos colegios tienen estudiantes con discapacidad visual, auditiva o cognitiva
- Conectividad limitada (solo WiFi, sin 4G estable)
- Presupuesto limitado → headsets económicos (no Meta Quest Pro — sino Quest Go o cardboard con Android)
- El contenido educativo es ciencias naturales: ciclo del agua, fotosíntesis, ecosistemas
- El sistema debe ser usado por profesores sin formación técnica avanzada

**Parte 1 — Análisis de requerimientos de accesibilidad (8 puntos)**

Diseña un análisis de los requisitos de accesibilidad para este sistema. Incluye:
- ¿Qué tipos de discapacidad debes considerar? ¿Por qué?
- Rpta: la auditiva, porque gran parte del contenido de ciencias se explica mediante la voz del profesor virtual; la visual, considerando que algunos estudiantes pueden tener baja visión, daltonismo o problemas de visión no diagnosticados, además de que muchos gráficos dependen del uso de colores; y la cognitiva, ya que los términos científicos pueden ser difíciles de entender, por lo que es importante presentarlos de forma más simple y clara para que todos los estudiantes de 12 a 17 años puedan comprenderlos mejor.
- ¿Qué restricciones del contexto (rural, económico, sin expertos técnicos) afectan las soluciones de accesibilidad disponibles?
- Rpta: Como la aplicación está pensada para funcionar en hardware económico como Oculus Go o Cardboard, toda la interacción debe hacerse con movimientos de cabeza y controles básicos, sin depender de gestos complejos. Además, debido a la conectividad limitada en muchas zonas, todas las funciones de accesibilidad deben estar integradas y funcionar sin internet. Finalmente, como los profesores no necesariamente tienen conocimientos técnicos, las opciones de accesibilidad deben ser fáciles de activar y usar, con una interfaz simple y directa.
- ¿Qué contenidos del currículum (ciclo del agua, fotosíntesis) plantean desafíos específicos de accesibilidad?
- Rpta: Los temas del ciclo del agua y la fotosíntesis presentan desafíos de accesibilidad porque incluyen procesos que no se pueden ver fácilmente y suelen explicarse con muchos elementos visuales y colores. Por eso, es importante complementar la información con otros tipos de retroalimentación y presentar los conceptos de forma más clara, para que todos los estudiantes, especialmente quienes tienen dificultades visuales, puedan entenderlos sin depender solo de gráficos o colores.



**Parte 2 — Propuesta de diseño inclusivo (10 puntos)**

Diseña un sistema XR accesible para este contexto. Tu diseño debe incluir:
- Mínimo 5 características de accesibilidad concretas (no genéricas: "agregar subtítulos" → especifica cómo, en qué idiomas, en qué formato)
- Rpta: La aplicación incluirá varias funciones de accesibilidad, como subtítulos bilingües (castellano y quechua), audiodescripciones para explicar los elementos visuales, navegación mediante la mirada para evitar el uso de controles, representaciones con formas y texturas en lugar de depender solo de colores durante las simulaciones, y un modo de alto contraste o monocromático que facilite la visualización para estudiantes con baja visión.
- Cómo el sistema se adapta a diferentes niveles de capacidad sin necesitar configuración técnica compleja
- Rpta: La primera vez que se abra la aplicación, se mostrará una breve calibración guiada y sencilla. Un personaje hablará en el idioma elegido y ayudará al estudiante a configurar la forma de interactuar, ya sea con la mirada o usando el botón físico. Además, se mostrarán textos en diferentes tamaños para que el estudiante elija el que le resulte más cómodo, ajustando automáticamente toda la interfaz a esa configuración.
- Una característica creativa que no existe en las apps XR actuales y que sería especialmente útil para este contexto peruano específico.
- Rpta: Aprovechando que los smartphones usados en visores Cardboard poseen motores de vibración estándar pero potentes, diseñaremos el sistema Yachay-Háptico. Al explorar el ciclo del agua o los ecosistemas andinos, el teléfono traducirá las frecuencias de sonido de la naturaleza en patrones vibratorios específicos en el chasis del visor (vibración intermitente rápida para la evaporación/calor, vibración larga y profunda para la lluvia/precipitación). Esto permite a los estudiantes con discapacidad auditiva y visual captar de forma táctil y craneal la intensidad del fenómeno natural simulado.

**Parte 3 — Validación (7 puntos)**

Diseña un plan de validación de accesibilidad para el sistema. Responde:
- ¿Cómo probarías la accesibilidad del sistema antes del lanzamiento?
- Rpta: Mediante pruebas de simulación de caja negra de accesibilidad en laboratorio: configurar el sistema en el hardware objetivo (dispositivos Android de gama baja) y aplicar filtros de software que emulen deuteranopia, reducción del campo visual al 20%, y pruebas de uso silenciando por completo los canales de audio.
- ¿Qué personas específicas incluirías en el proceso de prueba?
- Rpta: Estudiantes de colegios de Ayacucho y Huancavelica con discapacidades diagnosticadas (o con reportes de baja visión/atención por parte de los docentes). Profesores rurales de las zonas objetivo (para validar si la interfaz de inicio es fácil de lanzar en el aula). Especialistas pedagógicos en educación bilingüe intercultural (EBI) del MINEDU.
- ¿Qué métricas usarías para determinar si el sistema es "accesible"?
- Rpta:Tasa de éxito en la tarea, porcentaje de estudiantes con discapacidad que logran completar la experiencia del ciclo del agua sin asistencia externa. Tiempo de resolución de la tarea, medir si un estudiante con discapacidad visual tarda más del doble de tiempo que un alumno promedio; si el desfase es mínimo, la UI es eficiente. Índice de Confort y Cansancio, reporte cualitativo/emotivo post-sesión para asegurar que el parpadeo o el movimiento de los Cardboard no cause mareos en sesiones de 15 minutos.
- ¿Cómo incorporarías feedback de personas con discapacidad al proceso de diseño (no solo de prueba)?
- Rpta: Aplicando el codiseño desde la fase de prototipo en papel y maquetas interactivas 2D para móviles. Antes de escribir código en Unity, se realizarán talleres en las regiones con los estudiantes y docentes usando muestras de audio en Quechua y paletas de colores impresas, asegurando que su retroalimentación modifique la arquitectura de la aplicación desde el primer día, cumpliendo con la premisa: "Nada sobre nosotros sin nosotros".

---

## CRITERIOS DE EVALUACIÓN

| Sección | Puntos | Criterio |
|---------|--------|---------|
| A — Opción Múltiple | 25 pts | Respuesta correcta única por pregunta |
| B1 — Espacios en blanco | 12 pts | Término técnico exacto en cada espacio |
| B2 — Relacionar columnas | 10 pts | Correspondencia correcta |
| C1 — Diagnóstico de código | 12 pts | 4 problemas identificados con solución correcta |
| C2 — Comparación enfoques | 8 pts | Análisis profundo de diferencias y casos |
| C3 — Caso rehabilitación | 8 pts | Barreras y soluciones específicas por perfil |
| D — Caso avanzado | 25 pts | Análisis contextualizado, creatividad, validación |
| **TOTAL** | **100 pts** | |

---

*PSISP08075 | Universidad Autónoma del Perú | Ingeniería de Sistemas | Semana 13 | 2026-1*
