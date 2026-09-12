#include <iostream>
#include <string>
using namespace std;

struct reg_estudiantes
{
    string nombre, carrera, semestre;
    float promedio;
};

int main()
{
    reg_estudiantes estudiante[5] = {
        {"Alex", "Sistemas", "Tercero", 9.2},
        {"Maria", "Medicina", "Quinto", 8.8},
        {"Pedro", "Sistemas", "Primero", 7.5},
        {"Ana", "Derecho", "Septimo", 9.5},
        {"Luis", "Contabilidad", "Tercero", 8.0}};

    int opcion;
    cout << "========================================" << endl;
    cout << "          MENU DE BUSQUEDA" << endl;
    cout << "========================================" << endl;
    cout << "1. Buscar Alumno por Nombre" << endl;
    cout << "2. Buscar Alumnos por Carrera" << endl;
    cout << "Selecciona una opcion (1-2): ";
    cin >> opcion;

    string busqueda;
    bool encontrado = false; // Nos ayuda a saber si encontramos algo o no

    switch (opcion)
    {
    case 1:
        cout << endl
             << "Ingresa el nombre del alumno a buscar: ";
        cin >> busqueda;

        for (int i = 0; i < 5; i++)
        {
            if (estudiante[i].nombre == busqueda)
            {
                cout << "--- Datos del Alumno ---" << endl;
                cout << "Nombre: " << estudiante[i].nombre << endl;
                cout << "Carrera: " << estudiante[i].carrera << endl;
                cout << "Semestre: " << estudiante[i].semestre << endl;
                cout << "Promedio: " << estudiante[i].promedio << endl;
                encontrado = true; // Marcamos que sí existía
            }
        }

        if (encontrado == false)
        {
            cout << endl
                 << "Alumno no registrado en sistema" << endl;
        }
        break;

    case 2:
        cout << endl
             << "Ingresa la carrera a buscar: ";
        cin >> busqueda;

        cout << endl
             << "--- Alumnos inscritos en " << busqueda << " ---" << endl;
        for (int i = 0; i < 5; i++)
        {
            if (estudiante[i].carrera == busqueda)
            {
                cout << "- " << estudiante[i].nombre << " (Semestre: " << estudiante[i].semestre << ")" << endl;
                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            cout << "No hay alumnos inscritos en esta carrera." << endl;
        }
        break;

    default:
        cout << "Opcion no valida." << endl;
        break;
    }

    return 0;
}
