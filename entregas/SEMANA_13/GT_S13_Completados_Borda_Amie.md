# S13 — GUÍA DE TRABAJO DEL ESTUDIANTE
## Curso: Realidad Virtual y Aumentada | PSISP08075
### Semana 13 — Accesibilidad en RA y RV

---

| Campo | Detalle |
|-------|---------|
| **Estudiante** | Borda Garcia, Amie Paola |
| **Código** | 2231893474 |
| **Fecha** | 18/07/2026 |
| **Semana** | 13 — Accesibilidad en RA y RV |

---

## SECCIÓN A — OPCIÓN MÚLTIPLE (25 puntos, 2.5 pts c/u)

**A1.** Según el modelo social de la discapacidad, cuando un usuario en silla de ruedas no puede usar una app de VR que requiere ponerse de pie para alcanzar objetos, el problema principal es:
- [ x ] b) El diseño de la app que no consideró usuarios con movilidad reducida

**A2.** ¿Cuál es el ratio de contraste mínimo que exige WCAG 2.1 nivel AA para texto normal sobre fondo?
- [ x ] c) 4.5:1

**A3.** Un usuario con **daltonismo rojo-verde (deuteranopia)** usa tu app AR de medicina donde el color rojo indica tejido dañado y verde indica tejido sano. ¿Cuál es la solución de accesibilidad más completa?
- [ x ] c) Mantener los colores pero añadir forma, icono de advertencia y texto overlay como canales adicionales de información

**A4.** La técnica "Dwell Time" en VR/AR permite:
- [ x ] b) Seleccionar objetos simplemente mirándolos durante un tiempo configurado, sin usar las manos

**A5.** ¿Por qué el texto AR sobre fondo transparente es particularmente problemático para personas con baja visión?
- [ x ] c) Porque el fondo del mundo real es variable e impredecible, haciendo imposible garantizar contraste suficiente

**A6.** El **cybersickness** se produce principalmente por:
- [ x ] b) Una discordancia entre la información visual (movimiento en VR) y la información vestibular (el cuerpo no se mueve)

**A7.** ¿Qué es el documento **XAUR** (XR Accessibility User Requirements)?
- [ x ] b) La extensión de WCAG publicada por el W3C para definir requisitos de accesibilidad específicos para XR

**A8.** En el script `SubtitulosXR.cs` visto en clase, el método se coloca en `LateUpdate()` en lugar de `Update()` porque:
- [ x ] b) `LateUpdate()` se ejecuta después de que la cámara se ha movido, garantizando que los subtítulos se posicionen correctamente respecto a la posición final de la cámara en ese frame

**A9.** El "efecto bordillo" (curb cut effect) en diseño accesible se refiere a:
- [ x ] b) El principio de que las soluciones diseñadas para personas con discapacidad terminan beneficiando a todos los usuarios

**A10.** ¿Cuál es la diferencia clave entre **locomoción libre** y **teleportación** en VR desde el punto de vista de la accesibilidad?
- [ x ] c) La locomoción libre con joystick puede causar cybersickness ya que el cuerpo no se mueve físicamente, mientras la teleportación elimina esa discordancia

---

## SECCIÓN B — COMPLETAR Y RELACIONAR (22 puntos)

### B1 — Completar espacios en blanco (12 puntos, 2 pts c/u)

1. WCAG son las siglas de **Web Content Accessibility Guidelines** y sus cuatro principios (POUR) son: Perceptible, **Operable**, Comprensible y Robusto.
2. El componente de Unity que permite asignar una etiqueta accesible y descripción a cualquier GameObject para que el lector de pantalla del sistema operativo los pueda leer se llama **Accessible Component (o Access Node)**.
3. El **Cybersickness (o Mareo Cibernético)** es el conjunto de síntomas de náusea, desorientación y malestar causado por la discordancia entre la información visual del entorno VR y las señales del sistema vestibular.
4. Para que el texto en AR sea legible independientemente del fondo del mundo real, se debe añadir un **Backplate (Fondo opaco)** semiopaco detrás del texto.
5. Según WCAG 2.1, las imágenes o elementos que contienen información no deben usar **el color** como único medio de transmitir esa información — deben incluir también forma, patrón o texto.
6. La organización que publicó el documento XAUR (XR Accessibility User Requirements) es el **W3C (World Wide Web Consortium)**.

### B2 — Relacionar columnas (10 puntos, 1 pt c/u)

| # | Barrera de accesibilidad | Letra | Solución en XR |
|---|--------------------------|-------|----------------|
| 1 | Usuario sordo no puede escuchar narración de audio en VR | **C** | A. Backing panel semiopaco + texto outline |
| 2 | Usuario con daltonismo no distingue zonas de peligro codificadas en rojo | **D** | B. Dwell time (selección por mirada con tiempo configurable) |
| 3 | Texto AR ilegible sobre fondos claros del mundo real | **A** | C. Subtítulos 3D anclados a la cámara (head-locked) |
| 4 | Usuario con Parkinson no puede presionar botones pequeños del controller | **B** | D. Iconos de forma + texto "PELIGRO" redundante al color |
| 5 | Primera vez en VR — usuario adulto mayor siente náuseas con joystick | **E** | E. Modo teleportación + vignette dinámico + velocidad ajustable |
| 6 | Usuario con autismo siente sobrecarga sensorial con muchos estímulos | **G** | F. Botones más grandes + zona de toque ampliada + modo hold |
| 7 | Usuario en silla de ruedas no puede alcanzar objetos colocados muy arriba en VR | **H** | G. Modo calma: reducir objetos, sonidos y velocidad |
| 8 | App sin modo pausa: usuario con epilepsia expuesto a flashes continuos | **J** | H. Reposicionar UI dentro del rango de movimiento sentado |
| 9 | App de entrenamiento VR usa solo audio para dar feedback de errores | **I** | I. Semáforos, iconos y vibración como canales adicionales |
| 10 | Usuario ciego quiere explorar objetos 3D en un museo VR | **K** | J. Máximo flash rate configurado + botón de pausa siempre visible |
| | | | K. Audio descriptivo espacial + hápticos de confirmación |

---

## SECCIÓN C — ANÁLISIS Y DIAGNÓSTICO (28 puntos)

### C1 — Diagnóstico de código con problemas de accesibilidad (12 puntos)

| # | Línea(s) | Problema de accesibilidad | Tipo de discapacidad afectada | Solución correcta |
|---|----------|--------------------------|-------------------------------|-------------------|
| 1 | 18-20 | **Tamaño de zona táctil insuficiente:** Los botones de 80x25 son demasiado pequeños, violando los estándares de tamaño de objetivo (Target Size). | Discapacidad motora (Parkinson, temblores) y visual (Baja visión). | Aumentar el `sizeDelta` a mínimo `100x50` (o 44x44 pt según WCAG). |
| 2 | 23 | **Timeout sin advertencia:** La sesión se cierra automáticamente a los 60s, sin permitir al usuario extender el tiempo. | Discapacidad cognitiva y motora (usuarios que leen o se mueven más lento). | Crear un panel que avise "La sesión terminará en 10s" con un botón grande para "Extender tiempo". |
| 3 | 28-33 | **Frecuencia de parpadeo peligrosa:** El cálculo genera un destello (flash) de 8 ciclos por segundo (8Hz), lo cual está en la zona de riesgo (3 a 30Hz). | Epilepsia fotosensible. | Reducir `velocidadParpadeo` a `2f` (menos de 3Hz) o usar una transición suave de opacidad sin flashes. |
| 4 | 37-40 | **Dependencia exclusiva del color/sonido:** El método `MostrarError` indica el error solo pintando de rojo y tocando un sonido. No hay texto ni iconografía. | Daltonismo y personas sordas o con discapacidad auditiva. | Además del color y sonido, añadir: `textoEstado.text = "ERROR";` y mostrar un icono de alerta (`[!]`). |

---

### C2 — Comparación: Audio Narration vs Spatial Audio Descriptions (8 puntos)

1. **¿Cuál enfoque representa mejor el modelo social de la discapacidad?**
El **Enfoque B (Spatial Audio)**. El modelo social dicta que es el entorno el que debe adaptarse para incluir al usuario. El Enfoque B permite al usuario ciego explorar el mundo con la misma agencia, libertad e interactividad que un usuario vidente. El Enfoque A es un parche segregador (forzar a escuchar una cinta antes de jugar).
2. **¿Qué limitaciones tiene el Enfoque A que el Enfoque B no tiene?**
Impone una altísima carga cognitiva (el usuario debe memorizar 2 minutos de información espacial antes de moverse). Además, no funciona para entornos dinámicos (si un objeto se mueve, la narración inicial queda obsoleta).
3. **¿En qué tipo de app VR el Enfoque A sería más apropiado que el B?**
En una experiencia VR cinematográfica de 360 grados, un video pasivo lineal o una app de relajación guiada donde el usuario no tiene capacidad de movimiento ni interacción espacial.
4. **¿Cómo implementarías el Enfoque B en Unity a nivel técnico?**
Añadiría un componente `SphereCollider` (como trigger) y un `XRGrabInteractable` a los objetos. Usaría el evento `OnHoverEntered` (cuando el raycast o la mano del usuario toca el objeto) para disparar un `AudioSource.PlayOneShot()`. El `AudioSource` tendría su parámetro *Spatial Blend* ajustado a `1.0` (3D total) para que el sonido provenga exactamente de la posición del objeto en el espacio.

---

### C3 — Caso: App de rehabilitación física en VR (8 puntos)

| Paciente | Barrera 1 | Solución 1 | Barrera 2 | Solución 2 |
|----------|-----------|-----------|-----------|-----------|
| **A (65 años, cirugía hombro)** | Cybersickness por ser su primera vez en VR. | Movimiento por **Teleportación** + efecto **Vignette** (oscurecer bordes al moverse). | Imposibilidad de alcanzar objetos altos por el límite físico de su hombro operado. | **Calibración asimétrica:** que el sistema multiplique el movimiento de su brazo derecho en VR (movimiento amplificado). |
| **B (parálisis mano derecha)** | Dificultad para mantener presionado el botón "Grip" (agarrar) de los controllers. | Reemplazar el gesto de mantener apretado por **Toggle Grip** (clic para agarrar, clic para soltar) o **Auto-Grab** por proximidad. | No puede interactuar con paneles UI porque requiere apuntar y hacer clic. | Activar **Dwell Time** (selección por mirada prolongada) para interactuar con los menús sin usar las manos. |
| **C (sordo, 22 años)** | No escucha las instrucciones habladas por el entrenador virtual. | **Subtítulos 3D anclados a la cabeza** (Head-locked) con panel de fondo oscuro para alto contraste. | No percibe la alarma de error o colisión mediante audio. | Feedback **Háptico** (vibración del controller) y destello rojo en los bordes de la pantalla (Visual cue). |
| **D (daltonismo, codos)** | Confunde las esferas de objetivo (rojas) con el entorno (verde). | Añadir **formas distintas** (esferas para aciertos, cubos con iconos de 'X' para errores). | Imposibilidad de estirar los brazos completamente debido a la cirugía de codos. | **Distance Grab (Force Pull):** permitir que seleccione el objeto a la distancia con un rayo láser y lo atraiga hacia él. |

---

## SECCIÓN D — CASO AVANZADO (25 puntos)

### Parte 1 — Análisis de requerimientos de accesibilidad (8 puntos)

- **Tipos de discapacidad a considerar:** Visual (baja visión y daltonismo), auditiva, motora leve y cognitiva (TDAH/Autismo, común en edad escolar).
- **Restricciones del contexto:**
  1. *Hardware:* Usar Google Cardboard (móviles Android) significa **ausencia de controladores 6DOF**, limitando la interacción a giros de cabeza (3DOF) y un solo botón físico.
  2. *Conectividad:* Todo el contenido, paquetes de idiomas (Quechua/Español) y audio-descripciones deben estar descargados offline.
  3. *Profesores:* La interfaz de configuración de accesibilidad debe ser extremadamente intuitiva y visual, sin jerga técnica ("Activar subtítulos", no "Enable Canvas World Space").
- **Desafíos del currículum:** Procesos como la fotosíntesis son abstractos y visuales. Si solo se muestran partículas flotando, los estudiantes con baja visión o discapacidad cognitiva perderán la información. Requiere audio descriptivo redundante y ritmos pausados.

### Parte 2 — Propuesta de diseño inclusivo (10 puntos)

**Sistema: "AyniXR - Educación Inclusiva"**

**5 características de accesibilidad concretas:**
1. **Interacción Gaze-to-Dwell:** Dado que no hay controllers, el usuario selecciona opciones mirando un objeto fijamente por 2.5 segundos (con una barra circular de carga visual).
2. **Subtítulos Bilingües de Alto Contraste:** Textos en Español y Quechua renderizados en blanco con un `Outline` negro grueso y un `Backplate` de 70% de opacidad, anclados al FOV inferior de la cámara.
3. **Modo "Pausa Sensorial" (Cognitivo):** Si el estudiante se abruma, mirar directamente al cielo activa un modo donde el entorno se oscurece al 50%, la música se detiene y solo queda el sonido de la respiración.
4. **Feedback de Audio Espacial (Visual):** Los elementos del ecosistema emiten sonidos característicos (el río suena a la izquierda, el sol emite un zumbido cálido arriba) para guiar la atención sin depender de la vista.
5. **Modo "Companion App" para el Profesor:** El profesor controla la sesión desde el celular *antes* de insertarlo en el Cardboard, seleccionando perfiles de accesibilidad pre-guardados (Ej. Perfil "Baja visión": aumenta la escala 3x de los objetos).

**Característica Creativa Exclusiva ("Acompañante Andino"):**
Un cóndor o alpaca virtual que actúa como "Ancla Cognitiva y de Accesibilidad". En lugar de flechas UI que rompen la inmersión, este animal vuela hacia donde ocurre la acción importante (ej. hacia la hoja durante la fotosíntesis) emitiendo un sonido espacial y dejando un rastro brillante. Esto guía a los usuarios con ceguera parcial mediante el sonido, y a los usuarios con déficit de atención mediante una guía visual amigable, adaptándose al contexto cultural andino.

### Parte 3 — Validación (7 puntos)

- **Proceso de prueba antes del lanzamiento:** Realizaríamos pruebas formativas iterativas (Co-Diseño). No esperaríamos a tener el 3D final, sino que probaríamos prototipos tempranos usando pantallas 2D panorámicas antes de pasarlos a VR.
- **Participantes específicos:** Trabajaríamos directamente con estudiantes de los colegios rurales en Ayacucho que tengan diagnósticos documentados (estudiantes en el espectro autista, con hipoacusia y con baja visión), además de sus maestros.
- **Métricas:** 
  - *Tasa de Finalización de Tareas:* ¿Pudo el estudiante llegar al final de la lección del ciclo del agua por sí mismo?
  - *SSQ (Simulator Sickness Questionnaire) Adaptado:* Usando un sistema de "caritas" para que los niños evalúen su nivel de mareo tras 10 minutos de uso.
  - *Tiempo en Tarea:* ¿El Dwell Time está configurado muy rápido (frustración) o muy lento (fatiga)?
- **Incorporación de Feedback:** Bajo la premisa "Nada sobre nosotros sin nosotros", el feedback de los estudiantes con discapacidad no será solo un "bug report". Si un alumno con TDAH indica que la lluvia VR lo distrae, el equipo integrará esa opinión creando un "Modo simplificado" en la arquitectura central de la aplicación.

***
