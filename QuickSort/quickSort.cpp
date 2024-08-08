#include <iostream>
using namespace std;

// Fun��o para trocar dois elementos
void swap(int &a, int &b) {
    int temp = a;
    a = b;
    b = temp;
}

// Fun��o para encontrar o �ndice do piv�
int partition(int arr[], int low, int high) {
    int pivot = arr[high]; // Escolhe o �ltimo elemento como piv�
    int i = (low - 1); // �ndice do menor elemento

    for (int j = low; j < high; j++) {
        // Se o elemento atual � menor ou igual ao piv�
        if (arr[j] <= pivot) {
            i++; // Incrementa o �ndice do menor elemento
            swap(arr[i], arr[j]); // Troca os elementos
        }
    }
    swap(arr[i + 1], arr[high]); // Coloca o piv� na posi��o correta
    return (i + 1);
}

// Fun��o recursiva de Quick Sort
void quickSort(int arr[], int low, int high) {
    if (low < high) {
        // Encontra o �ndice do piv�, tal que todos os elementos menores que o piv� est�o � sua esquerda e os maiores � sua direita
        int pi = partition(arr, low, high);

        // Ordena os elementos antes e depois do piv�
        quickSort(arr, low, pi - 1);
        quickSort(arr, pi + 1, high);
    }
}

// Fun��o para imprimir o array
void printArray(int arr[], int size) {
    for (int i = 0; i < size; i++)
        cout << arr[i] << " ";
    cout << endl;
}

int main() {
    int arr[] = {10, 7, 8, 9, 1, 5,100,0,1,-1,100,200,300,400,100};
    int n = sizeof(arr) / sizeof(arr[0]);

    cout << "Array antes da ordena��o: ";
    printArray(arr, n);

    quickSort(arr, 0, n - 1);

    cout << "Array depois da ordena��o: ";
    printArray(arr, n);
    
    return 0;
}
