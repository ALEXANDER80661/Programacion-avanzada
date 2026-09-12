#include <iostream>
#include <string>
using namespace std;

// Crear un registro que almacene los datos de 5 estudiantes

struct reg_estudiantes
{
    string nombre, carrera, semestre;
    float promedio;

} estudiante[5];

int main()
{
    // Registro de alumnos
    for (i = 0; i < 5; i++)
    {
        cout << "Ingresa el nombre del estudiante" << endl;
        cin >> estudiante[i].nombre;

        cout << "Ingresa la carrera del estudiante" << endl;
        cin >> estudiante[i].carrera;

        cout << "Ingresa el Semestre del estudiante" << endl;
        cin >> estudiante[i].semestre;

        cout << "Ingresa el promedio del estudiante" << endl;
        cin >> estudiante[i].promedio;
    }
}
// Mostrar los datos de los alumnos inscritos
cout << "Datos de los estudiantes";
<< endl;
for (int i = 0; i < 5; i++)
{
    cout << "Nombre: " << estudiante[i].nombre << endl;
    cout << "Carrera: " << estudiante[i].carrera << endl;
    cout << "Semestre: " << estudiante[i].semestre << endl;
    cout << "Promedio: " << estudiante[i].promedio << endl;
    cout << "-----------------------------" << endl;
}

return 0;
}
