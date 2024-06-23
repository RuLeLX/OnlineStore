# Инструкция к запуску на своём к ПК

## Инициализация базы данных
<ol>
    <li>Скачайте СУБД PostgreSQL на свой ПК: https://www.postgresql.org/download/</li>
    <li>Открываем pgAdmin
        <ul>
            <li>Создаём базу данных toystore</li>
            <li>Владелец: postgres</li>
            <li>Пароль: userpass</li>
            <li>Порт: 5432</li>
            <li>В среде pgAdmin выполните SQL-код из файла InitDB.sql для создания БД</li>
        </ul>
    </li>
</ol>

## Подготовка проекта к запуску
<ol>
    <li>Скачайте dotnet sdk: https://dotnet.microsoft.com/en-us/download</li>
    <li>Создайте папку <любое название></li>
    <li>Откройте папку в любом редакторе, который вам удобен</li>
    <li>В терминале выполните команду: <i>dotnet new winforms</i></li>
    <li>В сформированном проекте удалите все файлы/директории, кроме файлов с расширениями .csproj</li>
    <li>Из скачанного архива или клонированного репозитория копируйте все файлы/папки в папку созданного вами проекта winforms</li>
    <li>Установите зависимости: <i>dotnet add package EEPlus</i> <i>dotnet add package Npgsql</i></li>
    <li>Запустите проект командой: <i>dotnet run</i></li>
</ol>
