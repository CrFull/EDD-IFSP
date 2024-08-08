#include <iostream>
using namespace std;

// Função para trocar dois elementos
void swap(int &a, int &b) {
    int temp = a;
    a = b;
    b = temp;
}

// Função para encontrar o índice do pivô
int partition(int arr[], int low, int high) {
    int pivot = arr[high]; // Escolhe o último elemento como pivô
    int i = (low - 1); // Índice do menor elemento

    for (int j = low; j < high; j++) {
        // Se o elemento atual é menor ou igual ao pivô
        if (arr[j] <= pivot) {
            i++; // Incrementa o índice do menor elemento
            swap(arr[i], arr[j]); // Troca os elementos
        }
    }
    swap(arr[i + 1], arr[high]); // Coloca o pivô na posição correta
    return (i + 1);
}

// Função recursiva de Quick Sort
void quickSort(int arr[], int low, int high) {
    if (low < high) {
        // Encontra o índice do pivô, tal que todos os elementos menores que o pivô estão à sua esquerda e os maiores à sua direita
        int pi = partition(arr, low, high);

        // Ordena os elementos antes e depois do pivô
        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}

// Função para imprimir o array
void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++)
        cout << arr[i] << " ";
    cout << endl;
}

int main() {
    int arr[] = {49, 38, 58, 87, 34, 93, 26, 13};
    int n = sizeof(arr) / sizeof(arr[0]);

    cout << "Array antes da ordenação: ";
    printArray(arr, n);

    quickSort(arr, 0, n - 1);

    cout << "Array depois da ordenação: ";
    printArray(arr, n);
    
    return 0;
}
