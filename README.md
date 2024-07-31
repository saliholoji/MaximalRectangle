# [TR] Maximal Rectangle Solver

🎯 Bu proje, Leet Code üzerinde karşılaştığım "Maximal Rectangle" problemini çözmek için geliştirilmiştir. Bu problem, 0 ve 1'lerden oluşan bir matrisin içinde yalnızca 1'lerden oluşan en büyük dikdörtgeni bulmayı gerektiriyor. Bu tür problemler, optimizasyon ve algoritma geliştirme açısından harika bir egzersizdir.

🔗 Leetcode.com üzerinden problemi incelemek isterseniz: [https://leetcode.com/problems/maximal-rectangle/](https://leetcode.com/problems/maximal-rectangle/).
📈 Sunmuş olduğum çözüme ait, detaylı istatistikler: [https://leetcode.com/problems/maximal-rectangle/submissions/1339070305](https://leetcode.com/problems/maximal-rectangle/submissions/1339070305) 

## Özellikler

🔢 Maximal Rectangle problemi, bir matrisin her satırındaki 1'leri toplayarak bir histogram oluşturmayı ve bu histogramı kullanarak maksimum dikdörtgen alanını hesaplamayı içerir. Bu yaklaşımla, her satırda güncellenen histogramlar ve yığın (stack) yapısı kullanılarak hızlı ve etkin çözümler elde edilir.

Bu çözümde kullanılan temel adımlar:
- Her satır için histogram oluşturma
- Histogramı kullanarak maksimum alanı hesaplama

## Kullanılan Algoritmalar

### 1. MaximalRectangle
- Matrisi işlemek ve her satırda histogramı güncelleyerek ilerlemek için tasarlandı.
- Her satırdaki 1'leri toplar ve bir histogram oluşturur.
- Histogramı kullanarak maksimum dikdörtgen alanını hesaplar.

### 2. MaxHistogramArea
- Histogramın maksimum alanını hesaplamak için kullanılır.
- Yığın (stack) yapısını kullanarak, her sütun için maksimum alanı hesaplar.
- Histogramın her bir elemanı için alanı hesaplayarak maksimum alanı döner.

## Görseller

![0](https://github.com/user-attachments/assets/000cfd31-e3ee-4183-8e79-4455901acb83) ![0solve](https://github.com/user-attachments/assets/714fa003-59f7-467a-9d7e-23757d9ad7c2)

![1](https://github.com/user-attachments/assets/6895020a-5f0c-43d4-957b-bbf72ac2db2c)![1solve](https://github.com/user-attachments/assets/ab06a770-4d11-41b9-8b05-cf50c7930a3c)


## Kurulum

1. Bu projeyi klonlayın:
    ```sh
    git clone https://github.com/saliholoji/MaximalRectangleSolver2024.git
    ```
2. Proje dizinine gidin:
    ```sh
    cd maximal-rectangle-solver
    ```
3. Gerekli bağımlılıkları yükleyin ve projeyi çalıştırın (Visual Studio veya .NET Core SDK gerektirir):

### Visual Studio ile:
- Proje dosyasını (`.csproj`) Visual Studio ile açın.
- Çözümü derleyin (Build Solution).
- Programı çalıştırın (Run).

### .NET Core CLI ile:
    ```sh
    dotnet build
    dotnet run
    ```

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. Daha fazla bilgi için `LICENSE` dosyasına bakın.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın. Her türlü katkıdan memnuniyet duyarız!

# [EN] Maximal Rectangle Solver

🎯 This project was developed to solve the "Maximal Rectangle" problem I encountered on Leet Code. This problem requires finding the largest rectangle consisting solely of 1s within a matrix of 0s and 1s. Such problems are great exercises for optimization and algorithm development.

🔗 If you want to review the problem on Leetcode.com: [https://leetcode.com/problems/maximal-rectangle/](https://leetcode.com/problems/maximal-rectangle/).

📈 Detailed statistics of the solution I presented: [https://leetcode.com/problems/maximal-rectangle/submissions/1339070305](https://leetcode.com/problems/maximal-rectangle/submissions/1339070305) 

## Features

🔢 The Maximal Rectangle problem involves creating a histogram by summing the 1s in each row of the matrix and then using this histogram to calculate the maximum rectangle area. This approach yields fast and efficient solutions by updating histograms in each row and using a stack structure.

Key steps used in this solution:
- Creating a histogram for each row
- Calculating the maximum area using the histogram

## Algorithms Used

### 1. MaximalRectangle
- Designed to process the matrix and update the histogram for each row.
- Sums the 1s in each row and creates a histogram.
- Uses the histogram to calculate the maximum rectangle area.

### 2. MaxHistogramArea
- Used to calculate the maximum area of the histogram.
- Uses a stack structure to calculate the maximum area for each column.
- Returns the maximum area by calculating the area for each element of the histogram.

## Images

![0](https://github.com/user-attachments/assets/000cfd31-e3ee-4183-8e79-4455901acb83) ![0solve](https://github.com/user-attachments/assets/714fa003-59f7-467a-9d7e-23757d9ad7c2)

![1](https://github.com/user-attachments/assets/6895020a-5f0c-43d4-957b-bbf72ac2db2c)![1solve](https://github.com/user-attachments/assets/ab06a770-4d11-41b9-8b05-cf50c7930a3c)

## Installation

1. Clone this project:
    ```sh
    git clone https://github.com/saliholoji/MaximalRectangleSolver2024.git
    ```
2. Go to the project directory:
    ```sh
    cd maximal-rectangle-solver
    ```
3. Install the required dependencies and run the project (requires Visual Studio or .NET Core SDK):

### With Visual Studio:
- Open the project file (`.csproj`) with Visual Studio.
- Compile the solution (Build Solution).
- Run the program (Run).

#### With .NET Core CLI:
    ```sh
    dotnet build
    dotnet run
    ```

## License

This project is licensed under the MIT License. See the `LICENSE` file for more information.

## Contributing

If you would like to contribute, please send a pull request or open an issue. Any contribution is welcome!
