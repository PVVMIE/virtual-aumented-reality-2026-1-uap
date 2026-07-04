# Guía de Trabajo 12 — Datos y APIs en XR
## ⚠️ VERSIÓN ESTUDIANTE

**Estudiante:** TAIPE MONGE DANIELA YADIRA  **Código:** 2221899784
**Fecha:** 27/06/2026 | **Puntuación total:** ____/20

---

## PARTE I — Opción Múltiple (4 puntos)

**1.** En Unity, para hacer una petición HTTP sin bloquear el hilo principal se usa:
- [ ] a) Thread.Sleep() + HttpClient
- [x] b) IEnumerator + UnityWebRequest + yield return
- [ ] c) async/await con Task.Run()
- [ ] d) Socket.ReceiveAsync()

**Explicación:** Las coroutines permiten realizar peticiones HTTP de manera asíncrona sin congelar la ejecución del juego.

---

**2.** `[System.Serializable]` en una clase de Unity es necesario para:
- [ ] a) Que la clase pueda heredar de MonoBehaviour
- [x] b) Que JsonUtility.FromJson pueda deserializar la clase
- [ ] c) Que los campos aparezcan en el Inspector
- [ ] d) Que la clase sea visible en la Hierarchy

**Explicación:** Unity necesita que la clase sea serializable para convertir correctamente el JSON en objetos de C#.

---

**3.** JSON Server sirve para:
- [ ] a) Parsear JSON dentro de Unity más rápido
- [x] b) Crear un servidor REST mock local para desarrollo
- [ ] c) Convertir assets de Unity a formato JSON
- [ ] d) Serializar las escenas de Unity a JSON

**Explicación:** JSON Server permite simular una API REST local para pruebas y desarrollo.

---

**4.** ¿Por qué es mejor actualizar datos de API cada 10 segundos (no cada frame)?
- [ ] a) Unity no puede hacer requests más frecuentes
- [x] b) Demasiadas requests por segundo pueden saturar el servidor y gastar batería
- [ ] c) `UnityWebRequest` tiene un límite de 60 requests por minuto
- [ ] d) Los datos de sensores cambian solo cada 10 segundos

**Explicación:** Hacer requests constantemente puede generar sobrecarga en la red, mayor consumo de batería y problemas de rendimiento.

---

## PARTE II — Completar (4 puntos)

1. `yield return request.SendWebRequest()` pausa la coroutine hasta que la petición HTTP termina.

2. `JsonUtility.FromJson<TipoDeClase>(json)` convierte un string JSON a un objeto de C#.

3. Para que la API siempre retorne datos aunque no haya internet, se puede implementar un **cache** local con el último dato válido.

4. En HTTPS, las comunicaciones van **encriptadas** — importante para APIs que manejan datos sensibles.

---

## PARTE III — Análisis de código (8 puntos)


```csharp
IEnumerator ObtenerTemperatura()
{
    using (UnityWebRequest req = UnityWebRequest.Get("https://api.fabrica.com/sensor/1"))
    {
        yield return req.SendWebRequest();

        if (req.result == UnityWebRequest.Result.Success)
        {
            SensorData data = JsonUtility.FromJson<SensorData>(req.downloadHandler.text);
            textoTemp.text = $"Temp: {data.temperatura}°C";
            textoTemp.color = data.temperatura > 85f ? Color.red : Color.green;
        }
        else
        {
            textoTemp.text = "Sin conexión";
        }
    }
} 

3.1
El método realiza una petición HTTP GET a una API para obtener datos de un sensor. Primero espera la respuesta del servidor usando yield return. Si la petición es exitosa, convierte el JSON recibido en un objeto SensorData, muestra la temperatura en pantalla y cambia el color del texto dependiendo del valor de la temperatura. Si ocurre un error de conexión, muestra el mensaje “Sin conexión”.


3.2
[System.Serializable]
public class SensorData
{
    public int sensor_id;
    public float temperatura;
    public float humedad;
    public string estado;
}
3.3

La limitación es que JsonUtility tiene problemas con algunos nombres de campos JSON y estructuras más complejas. Una solución es mantener exactamente el mismo nombre del JSON en la variable de C# o utilizar librerías más completas como Newtonsoft Json.

3.4
if (req.result == UnityWebRequest.Result.Success)
{
    SensorData data = JsonUtility.FromJson<SensorData>(req.downloadHandler.text);
    textoTemp.text = $"Temp: {data.temperatura}°C";
    textoTemp.color = data.temperatura > 85f ? Color.red : Color.green;

    if (data.temperatura > 100f)
    {
        ActivarAlarma();
    }
}

PARTE IV — Diseño (4 puntos)
4.1

Para el proyecto de mi grupo se podría integrar una API de sensores ambientales o una API de información arquitectónica. La aplicación necesitaría datos como temperatura, humedad, ocupación de espacios o información de ambientes específicos. Estos datos se mostrarían en AR mediante paneles informativos flotantes o indicadores visuales en tiempo real dentro del entorno virtual. La actualización podría realizarse cada 10 o 15 segundos para evitar sobrecargar el sistema. Si no hubiera conexión a internet, la aplicación utilizaría un cache local con los últimos datos registrados y mostraría un mensaje indicando que se está trabajando en modo offline.

*PSISP08075 | Universidad Autónoma del Perú | 2026-1*