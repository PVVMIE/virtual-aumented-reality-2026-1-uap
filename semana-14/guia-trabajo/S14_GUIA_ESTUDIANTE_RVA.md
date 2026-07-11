# S14 — GUÍA DE TRABAJO ESTUDIANTIL
## Curso: Realidad Virtual y Aumentada | PSISP08075
### Semana 14 — Pruebas y Validación de Experiencias XR

---

> **Instrucciones generales**
> Esta guía contiene 4 secciones con distinto nivel de profundidad.
> **No incluye respuestas** — eso es responsabilidad tuya.
> Trabaja individualmente. Puedes consultar tus apuntes y la documentación oficial.
> **Tiempo estimado:** 90 minutos en total.

---

## SECCIÓN A — COMPRENSIÓN CONCEPTUAL (20 min)
### Preguntas de opción múltiple — una respuesta correcta por pregunta

---

**Pregunta 1.**
¿Cuál es la diferencia entre "testing" (pruebas) y "debugging" (depuración)?

a) Son sinónimos — ambos términos se refieren a encontrar errores en el código.

b) El testing detecta la existencia de defectos; el debugging localiza y corrige la causa raíz de defectos ya conocidos.

c) El testing es manual; el debugging es automático.

d) El testing ocurre antes del desarrollo; el debugging ocurre durante el desarrollo.

---

**Pregunta 2.**
Un desarrollador encuentra que su app AR tiene 30 FPS en el editor Unity pero solo 18 FPS en el dispositivo Android físico. ¿Cuál es el primer paso lógico para diagnosticar esta diferencia?

a) Cambiar el target platform a iOS y ver si mejora.

b) Desactivar ARCore en el proyecto porque consume demasiado.

c) Conectar el dispositivo Android al Profiler de Unity y capturar datos de CPU/GPU en el dispositivo real.

d) Reinstalar Unity en el dispositivo Android.

---

**Pregunta 3.**
En Unity Test Runner, ¿cuál es la diferencia entre un test de "Edit Mode" y uno de "Play Mode"?

a) Edit Mode funciona solo en Windows; Play Mode funciona en todas las plataformas.

b) Edit Mode prueba la lógica de scripts sin iniciar el ciclo de juego de Unity; Play Mode prueba con el ciclo completo (Start, Update, etc.) activo.

c) Edit Mode es más lento porque requiere compilar; Play Mode es más rápido porque usa caché.

d) No hay diferencia funcional — son alias del mismo tipo de test en Unity.

---

**Pregunta 4.**
¿Cuál de los siguientes es un ejemplo de bug con severidad "cosmética" pero prioridad P1?

a) La app crashea al iniciar — día antes de la presentación final.

b) La detección de planos no funciona en superficies oscuras — se reporta 3 meses antes del lanzamiento.

c) El logo de la empresa en la pantalla de inicio muestra la versión antigua — demo con el cliente mañana.

d) El texto de ayuda tiene un error de ortografía — versión 1.0 recién publicada.

---

**Pregunta 5.**
¿Qué es una "prueba de regresión" y cuándo se ejecuta?

a) Es una prueba que verifica que el hardware del dispositivo es compatible con la app; se ejecuta al inicio del proyecto.

b) Es una prueba que re-ejecuta casos previamente aprobados para verificar que las correcciones de bugs no rompieron funcionalidades existentes; se ejecuta después de cada corrección.

c) Es una prueba de rendimiento bajo condiciones extremas de carga; se ejecuta antes del lanzamiento.

d) Es una prueba que verifica la accesibilidad del producto; se ejecuta una vez al final del proyecto.

---

**Pregunta 6.**
Un equipo de desarrollo usa la convención de Conventional Commits y escribe el mensaje:
`fix(ar-placement): prevenir NullReferenceException en gestos sin plano — BUG-012`

¿Cuál de los siguientes beneficios NO proporciona directamente el ID de bug en el mensaje de commit?

a) Permite buscar exactamente qué cambio de código corrigió el bug con `git log --grep="BUG-012"`.

b) Permite que GitHub/GitLab cierre automáticamente el issue relacionado al hacer merge.

c) Permite al reviewer del PR verificar que el cambio corresponde a lo descrito en el bug report.

d) Impide que el mismo bug pueda ser reportado nuevamente por otro tester.

---

**Pregunta 7.**
¿Por qué el protocolo Think-Aloud es especialmente valioso para pruebas de usabilidad en XR comparado con una app de escritorio convencional?

a) Porque en XR el evaluador no puede ver la pantalla del usuario, entonces necesita escuchar lo que dice.

b) Porque en XR las interacciones son gestos y movimientos físicos difíciles de registrar solo con clickstream — la verbalización revela en tiempo real dónde el usuario se confunde en el espacio 3D.

c) Porque en XR el software no tiene logs de error, entonces la voz del usuario es la única fuente de datos.

d) Porque en XR todos los usuarios son principiantes y necesitan ser guiados durante la prueba.

---

**Pregunta 8.**
Un caso de prueba para AR tiene la siguiente precondición: "Superficie plana horizontal, texturizada, iluminación 300-600 lux". Dos testers ejecutan el mismo caso: uno sobre una mesa de madera (PASA), otro sobre un espejo horizontal (FALLA). ¿Cuál es la conclusión correcta?

a) Hay un bug en el código de ARCore que debe reportarse a Google.

b) El caso de prueba está mal diseñado porque los resultados son inconsistentes.

c) No hay un bug — la diferencia de resultado se explica por la precondición (el espejo no es superficie texturizada). El caso está bien diseñado para superficies texturizadas; se necesita un caso separado para superficies reflectantes.

d) Los dos testers deben repetir la prueba simultáneamente para determinar cuál resultado es correcto.

---

**Pregunta 9.**
¿Cuál de los siguientes describe mejor el rol de ARCore en relación con las pruebas de rendimiento en Android?

a) ARCore consume recursos adicionales de CPU para el análisis de la cámara, lo que puede reducir los FPS disponibles para la lógica del juego y los shaders Unity.

b) ARCore optimiza automáticamente el rendimiento del GPU y garantiza 60 FPS en todos los dispositivos certificados.

c) ARCore solo consume recursos cuando hay planos detectados; si no hay planos, el consumo de CPU es cero.

d) ARCore funciona en el GPU exclusivamente y no afecta el rendimiento de los scripts de Unity que corren en CPU.

---

**Pregunta 10.**
¿Cuál es el propósito de incluir un campo "Reproducibilidad" (ej: "10/10 intentos") en un bug report?

a) Indicar al desarrollador cuántas líneas de código están afectadas por el bug.

b) Comunicar la probabilidad de que el bug ocurra bajo las mismas condiciones, lo que ayuda a priorizar y a verificar que la corrección fue exitosa.

c) Limitar al tester a reportar solo bugs que ocurren siempre (10/10) y descartar los intermitentes.

d) Calcular automáticamente la prioridad del bug dividiendo 10 entre el número de intentos fallidos.

---

## SECCIÓN B — COMPRENSIÓN TÉCNICA (20 min)

### B.1 — Completar espacios en blanco

Completa los espacios con el término técnico correcto.

1. En Unity, el framework de pruebas integrado se llama _____________ y se accede desde el menú _____________  → General → _____________.

2. El tipo de test que verifica la lógica de un script sin necesitar que Unity esté en Play Mode se llama test de _____________ Mode.

3. En NUnit (el framework usado por Unity Test Runner), el atributo que marca un método como un test es _____________, y el método que se ejecuta antes de cada test individual para preparar el estado inicial se marca con _____________.

4. La métrica de rendimiento que mide cuántos objetos Unity envía al GPU para renderizar en cada frame se llama _____________ y en proyectos AR móvil debe mantenerse por debajo de _____________ para un rendimiento aceptable.

5. Cuando la causa de bajo FPS está en el GPU (renderizado de malla, shaders) se llama condición _____________ bound; cuando está en el CPU (scripts, física, IA) se llama condición _____________ bound.

6. En el ciclo de vida de un bug en un sistema de tracking, después de que el developer corrige el bug y hace commit, el estado del bug cambia de "Corregido" a "_____________ " hasta que el tester re-ejecuta el caso de prueba original.

7. El protocolo de pruebas de usabilidad en el que el usuario verbaliza sus pensamientos mientras usa el producto se llama protocolo _____________.

8. Una prueba que re-ejecuta todos los casos de prueba aprobados anteriormente después de una corrección se llama prueba de _____________.

---

### B.2 — Emparejar columnas

Empareja cada término (columna izquierda) con su definición correcta (columna derecha).

| # | Término | | Definición |
|---|---------|---|------------|
| 1 | Severidad | A | Urgencia con la que un bug debe ser corregido, según el contexto de negocio |
| 2 | Prioridad | B | Impacto técnico de un bug en la funcionalidad del sistema |
| 3 | Caso de prueba | C | Herramienta de Unity que registra datos de CPU, GPU, memoria y audio frame por frame |
| 4 | Plan de pruebas | D | Condición del sistema que debe ser verdadera antes de ejecutar un caso de prueba |
| 5 | Unity Profiler | E | Documento que define qué se prueba, cómo, cuándo y quién, con su alcance |
| 6 | Precondición | F | Unidad atómica de prueba: pasos específicos + entrada + resultado esperado |
| 7 | Test de regresión | G | Tipo de test que verifica funciones individuales de forma aislada sin dependencias externas |
| 8 | Unit test | H | Re-ejecución de casos de prueba ya aprobados para detectar nuevos defectos tras cambios |
| 9 | Think-Aloud | I | Confirmación de que el sistema funciona correctamente con todas sus partes integradas |
| 10 | Integration test | J | Protocolo de usabilidad donde el usuario verbaliza sus pensamientos en tiempo real |

---

### B.3 — Verdadero o Falso con justificación

Indica V (verdadero) o F (falso) y escribe UNA frase explicando por qué.

1. ____ Un test unitario (Unit Test) en Edit Mode puede probar si ARPlaneManager detecta planos correctamente en tiempo real.

2. ____ Es posible tener un bug con severidad CRÍTICA (la app crashea) y prioridad P4 (diferir indefinidamente).

3. ____ En el contexto de pruebas XR, "Happy Path" se refiere a la suite de casos de prueba más completa que verifica todos los escenarios posibles.

4. ____ ARCore puede detectar planos horizontales en superficies completamente uniformes sin textura visual (como una pared blanca lisa).

5. ____ El protocolo Think-Aloud requiere que el evaluador intervenga y guíe al usuario cuando este se confunde, para que pueda completar las tareas.

6. ____ En la "pirámide de pruebas", los tests unitarios (base de la pirámide) deberían ser los más numerosos porque son los más rápidos y baratos de ejecutar.

---

## SECCIÓN C — ANÁLISIS Y APLICACIÓN (25 min)

### C.1 — Diagnóstico de plan de pruebas con deficiencias

Lee el siguiente plan de pruebas creado por un estudiante para su proyecto AR y responde las preguntas.

```
PLAN DE PRUEBAS — Proyecto: CuidaPlanta AR
Autor: Estudiante
Fecha: Semana 14

Casos de prueba:
1. Probar que la planta aparezca.
2. Probar que el water button funcione.
3. Probar que se vea bien.
4. Probar que no crashee.
5. Verificar que el audio esté.

Notas: vamos a probar en mi celular y esperamos que todo funcione.
```

**Preguntas:**

a) Identifica **4 deficiencias específicas** en este plan de pruebas. Para cada una, nombra el elemento que falta y explica por qué es importante.

b) Reescribe el **caso de prueba 1** ("Probar que la planta aparezca") en formato profesional con todos los campos necesarios: ID, módulo, prioridad, precondiciones, pasos numerados, resultado esperado y estado inicial.

c) El plan dice "esperamos que todo funcione" — ¿qué problema revela esta frase sobre el enfoque del equipo hacia las pruebas? ¿Qué debería decir en su lugar?

---

### C.2 — Análisis de código con bugs a identificar

Lee el siguiente código de un gestor de AR y luego responde las preguntas:

```csharp
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class GestorColocacionAR : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject prefabObjeto;
    public GestorAccesibilidadColor colorManager;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private int contadorObjetos = 0;

    // Bug A está en este método
    public void AlTapEnPantalla(Vector2 posicionToque)
    {
        raycastManager.Raycast(posicionToque, hits, TrackableType.PlaneWithinPolygon);
        Vector3 posicion = hits[0].pose.position;
        Instantiate(prefabObjeto, posicion, hits[0].pose.rotation);
        contadorObjetos++;
    }

    // Bug B está en este método
    public void ResetearEscena()
    {
        GameObject[] objetos = GameObject.FindObjectsOfType<GameObject>();
        foreach (GameObject obj in objetos)
        {
            Destroy(obj);
        }
        contadorObjetos = 0;
    }

    // Bug C está en este método
    public void CambiarColorAccesibilidad()
    {
        colorManager.SiguienteModo();
    }

    // Bug D está en este método
    void Update()
    {
        if (contadorObjetos > 10)
        {
            Debug.Log("Máximo de objetos alcanzado");
            Debug.Log("Máximo de objetos alcanzado");
            Debug.Log("Máximo de objetos alcanzado");
        }
    }
}
```

**Preguntas:**

a) Para el **Bug A**: ¿en qué línea exacta está el bug? ¿Qué excepción lanzará? ¿Cuándo ocurrirá en condiciones de uso real? Escribe la versión corregida del método `AlTapEnPantalla`.

b) Para el **Bug B**: `Destroy(obj)` aplicado a TODOS los GameObjects de la escena es un problema grave. Explica por qué causaría un comportamiento incorrecto y cómo debería corregirse correctamente (sin destruir la cámara, el ARSession y otros objetos del sistema).

c) Para el **Bug C**: El método `CambiarColorAccesibilidad()` puede lanzar una NullReferenceException. ¿Cuándo ocurriría esto? Escribe la versión corregida.

d) Para el **Bug D**: El método de Unity `Debug.Log()` en Update() tiene un problema de rendimiento específico. ¿Qué es? ¿Cómo se corrige? ¿Cómo clasificarías la severidad de este bug?

---

### C.3 — Caso de gestión de bugs: Priorización bajo presión

**Contexto:** Eres el QA Lead de un equipo de 3 personas que desarrolla una app de AR educativa para colegios rurales de Cusco. La app superpone modelos 3D de historia inca sobre libros impresos (target de imagen). La presentación al MINEDU es en 48 horas. Tienen capacidad de corrección de aproximadamente 6 horas de trabajo.

**Bugs identificados en la última sesión de pruebas:**

| Bug ID | Descripción | Severidad | Tiempo estimado |
|--------|-------------|-----------|-----------------|
| BUG-A | El modelo 3D de Machu Picchu tiene texturas invertidas (se ve todo negro) | MAYOR | 1 hora |
| BUG-B | Al alejar demasiado la cámara del libro, el modelo AR desaparece bruscamente sin transición | MENOR | 2 horas |
| BUG-C | La app no solicita permiso de cámara en Android 13 (crash al iniciar en Pixel 7) | CRÍTICO | 3 horas |
| BUG-D | Los subtítulos del narrador en quechua no tienen backing panel (ilegibles sobre fondos claros) | MAYOR | 0.5 horas |
| BUG-E | El nombre de la app en el ícono tiene un acento incorrecto ("Ándes" en vez de "Andes") | COSMÉTICO | 0.25 horas |
| BUG-F | No hay modo de accesibilidad visual para daltónicos en el menú de configuración | MAYOR | 4 horas |
| BUG-G | Si el libro está doblado en diagonal, el tracking falla sin mensaje de error al usuario | MENOR | 1.5 horas |

**Preguntas:**

a) El tiempo disponible es 6 horas. Selecciona qué bugs corregir, ordénalos por prioridad y justifica cada decisión en 2-3 oraciones. Ten en cuenta el contexto del usuario (colegios rurales, MINEDU) y el tiempo de la presentación.

b) Para los bugs que NO corregirás antes de la presentación: ¿cómo los comunicarías al cliente (MINEDU) de manera profesional? Escribe un párrafo de 4-5 oraciones.

c) BUG-G dice "sin mensaje de error al usuario". ¿Por qué es importante mostrar mensajes de error claros cuando el tracking falla en AR? Relaciona tu respuesta con los principios de accesibilidad cognitiva vistos en S13.

---

## SECCIÓN D — SÍNTESIS Y REFLEXIÓN (25 min)

### Caso integrador: Sistema XR de Telesalud Rural en Perú

**Contexto:**

El Ministerio de Salud (MINSA) ha financiado el desarrollo de un sistema de VR para capacitación de técnicos de salud rurales en el manejo de emergencias obstétricas en zonas sin acceso a médicos especialistas (Puno, Loreto, Madre de Dios). El sistema funciona con headset VR (HTC Vive Focus 3) y simula el procedimiento de atención de un parto con complicaciones. Los técnicos practican el procedimiento en VR hasta dominarlo antes de atender casos reales.

El equipo entrega la versión beta y tú eres el responsable de validación. Tienes 2 semanas antes del primer despliegue piloto en 15 puestos de salud.

**Tarea (respuesta libre estructurada):**

**Parte D.1 — Plan de pruebas (10 min):**
Diseña el plan de pruebas para esta app de VR. Incluye:
- Al menos 3 tipos de prueba diferentes con justificación de por qué son críticos en este contexto
- 5 casos de prueba en formato correcto (ID, precondiciones, pasos, resultado esperado)
- Los criterios de aceptación mínimos para declarar el producto "listo para despliegue"
- Qué sucede si se encuentra un bug crítico 1 día antes del despliegue (protocolo de decisión)

**Parte D.2 — Pruebas de accesibilidad críticas (5 min):**
Identifica al menos 3 barreras de accesibilidad específicas de ESTE contexto (técnicos rurales, zonas remotas, headset VR) que NO serían relevantes en una app AR urbana convencional. Para cada una, propone cómo probarla y qué criterio de aceptación definiría.

**Parte D.3 — Reflexión sobre perseverancia (10 min):**
El escenario describe un sistema de salud real — si falla en producción, puede haber consecuencias en vidas humanas. Responde:
- ¿Cómo cambia la definición de "suficientemente probado" cuando el contexto es salud vs. un juego casual?
- ¿Qué rol juega la perseverancia en el proceso de pruebas cuando el costo del error es alto?
- Describe una situación concreta (real o hipotética) donde abandonar las pruebas antes de tiempo podría tener consecuencias irreversibles en este sistema.

*(Respuesta mínima esperada: 20 líneas combinadas entre D.1 + D.2 + D.3)*

---

## RÚBRICA DE AUTOEVALUACIÓN

Antes de entregar, revisa tu trabajo con esta escala:

| Criterio | 0 — No logrado | 1 — Parcialmente | 2 — Logrado |
|----------|----------------|------------------|-------------|
| Sección A: conceptos claros y sin contradicción | < 6 correctas | 6-8 correctas | 9-10 correctas |
| Sección B.1: términos técnicos precisos | < 4 correctos | 4-6 correctos | 7-8 correctos |
| Sección B.2: todos los emparejamientos correctos | < 6 pares | 6-8 pares | 9-10 pares |
| Sección C.1: 4 deficiencias identificadas y justificadas | 1-2 identificadas | 3 identificadas | 4 identificadas con justificación |
| Sección C.2: bugs identificados con causa y corrección | 1-2 bugs | 3 bugs | 4 bugs con código corregido |
| Sección C.3: priorización justificada con contexto | Lista sin justificación | Parcialmente justificada | Justificación con criterios de impacto |
| Sección D: integración coherente de conocimientos S11-S14 | Solo enumera conceptos | Aplica conceptos aislados | Integra y argumenta con coherencia |

**Puntaje máximo: 14 puntos**

---

*PSISP08075 | Universidad Autónoma del Perú | Ingeniería de Sistemas | Semana 14 | 2026-1*
