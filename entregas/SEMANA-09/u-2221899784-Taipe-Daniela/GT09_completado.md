# Guía de Trabajo 09 — Diseño de Escenarios 3D
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** TAIPE MONGE DANIELA YADIRA **Código:** 2221899784
**Fecha:** 06/06/2026| **Puntuación total:** ____/20

---
## PARTE I — Opción Múltiple (6 puntos)

1. ProBuilder en Unity permite:
- [ ] a) Importar modelos de Blender automáticamente
- [x] b) Crear geometría 3D directamente dentro del editor de Unity
- [ ] c) Generar texturas procedurales para cualquier objeto
- [ ] d) Compilar shaders personalizados para AR

Explicación:
ProBuilder es una herramienta de modelado integrada en Unity que permite crear y editar objetos 3D básicos directamente dentro del editor, sin necesidad de utilizar programas externos.


2. En iluminación "Baked", la iluminación:
- [ ] a) Se calcula en tiempo real en cada frame
- [x] b) Se precalcula y se guarda en texturas (lightmaps) — cero costo en runtime
- [ ] c) Se descarga desde un servidor en la nube
- [ ] d) Solo funciona con luz ambiental, no con luces direccionales

Explicación:
La iluminación baked se calcula previamente y se almacena en lightmaps, reduciendo significativamente el trabajo de procesamiento durante la ejecución del proyecto.


3. "Static Batching" en Unity:
- [ ] a) Combina todos los objetos en una sola malla en tiempo real
- [x] b) Agrupa objetos estáticos con el mismo material en un solo draw call
- [ ] c) Reduce el número de polígonos de los objetos automáticamente
- [ ] d) Solo funciona con objetos instanciados desde Prefabs

Explicación:
Static Batching optimiza el rendimiento agrupando objetos estáticos que utilizan el mismo material, disminuyendo la cantidad de draw calls que debe procesar el sistema.


4. LOD Group significa:
- [ ] a) Layer Of Darkness — control de sombras por capa
- [x] b) Level Of Detail — cambia la complejidad del modelo según distancia
- [ ] c) List Of Draw calls — optimización de renderizado
- [ ] d) Load On Demand — carga objetos cuando son necesarios

Explicación:
LOD (Level of Detail) permite mostrar versiones más simples de un modelo cuando se encuentra lejos de la cámara, reduciendo el número de polígonos procesados.


5. Para AR en celular Android de gama media, ¿cuántos draw calls máximo se recomienda?
- [ ] a) ≤500 draw calls
- [ ] b) ≤250 draw calls
- [x] c) ≤100 draw calls
- [ ] d) No hay límite, el driver los gestiona automáticamente

Explicación:
Mantener los draw calls por debajo de 100 ayuda a garantizar una experiencia fluida en aplicaciones AR para dispositivos móviles de gama media.


6. Occlusion Culling en Unity:
- [ ] a) Reduce la resolución de texturas en tiempo real
- [x] b) Evita renderizar objetos que están ocultos detrás de otros
- [ ] c) Elimina triángulos duplicados de la malla
- [ ] d) Combina materiales similares en uno solo

Explicación:
Occlusion Culling evita que Unity renderice objetos que no son visibles para la cámara porque están bloqueados por otros elementos, mejorando el rendimiento general.


## PARTE II — Completar (6 puntos)

1. El número de DRAW CALLS indica cuántas llamadas de renderizado hace el GPU por frame; debe mantenerse bajo en XR móvil.

2. Para que Static Batching funcione, los objetos deben estar marcados como STATIC en el Inspector de Unity.

3. El proceso de calcular la iluminación y guardarla en texturas se llama hacer BAKE (o baking de iluminación).

4. GPU Instancing es útil cuando hay muchos objetos IDÉNTICOS (mismo prefab y mismo material) en la escena.

5. Los Lightmaps son texturas que almacenan la ILUMINACIÓN precalculada de la escena estática.

6. En ProBuilder, para crear un pasillo o sala a partir de un cubo, se usa la operación de EXTRUSIÓN (EXTRUDE) de caras.



## PARTE III — Análisis de escena (5 puntos)

Un estudiante reporta estos valores en la ventana Stats de Unity:

Draw Calls: 347
Tris: 2.1M
Verts: 1.8M
FPS (Game View): 12

### 3.1 Identifica los 3 problemas principales de rendimiento

| Valor             | Problema                               | Impacto                                   |
|-------------------|-----------------------------------------|--------------------------------------------|
| Draw Calls: 347   | Exceso de draw calls                    | Sobrecarga del CPU y renderizado lento     |
| Tris: 2.1M        | Demasiados triángulos en la escena      | Alto consumo de GPU                        |
| FPS: 12           | Rendimiento muy bajo                    | Experiencia poco fluida para XR y AR       |

### 3.2 Propón 3 técnicas de optimización específicas

| Técnica           | Cómo aplicarla                                                    | Mejora esperada                       |
|-------------------|-------------------------------------------------------------------|---------------------------------------|
| Static Batching   | Marcar paredes, pisos y mobiliario fijo como Static               | Reducción de draw calls               |
| LOD Group         | Crear modelos simplificados para objetos lejanos                  | Menos triángulos procesados           |
| Occlusion Culling | Configurar oclusión para ocultar objetos fuera de la vista        | Incremento de FPS y menor carga GPU   |


## PARTE IV — Diseño de escenario (3 puntos)

| Elemento              | ¿Estático o dinámico? | Técnica de optimización      | Material (descripción)                  |
|-----------------------|----------------------|------------------------------|-----------------------------------------|
| Edificio principal    | Estático             | Static Batching + Lightmaps  | Concreto armado y vidrio                |
| Bancas urbanas        | Estático             | GPU Instancing               | Madera y estructura metálica            |
| Árboles               | Estático             | LOD Group                    | Vegetación con texturas optimizadas     |
| Personas/usuarios     | Dinámico             | Culling y animación optimizada | Material PBR simplificado             |

Conclusión:
La escena presenta problemas relacionados con una alta cantidad de draw calls y triángulos, lo que provoca un FPS muy bajo. Aplicando técnicas como Static Batching, LOD Group y Occlusion Culling se puede mejorar considerablemente el rendimiento y lograr una experiencia más fluida en dispositivos móviles y aplicaciones XR.

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*
