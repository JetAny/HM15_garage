Скрины для домашней рботы 19 и 20 находятся в файлах с номерами 18.1 -18.12
Middleware сделаны для проверки логина и пароля.
находятся в файле Prigram
app.UseMiddleware<LoginMiddleware>();
app.UseMiddleware<PasswordMiddleware>();
они закоментированы т.к. мешают переходить по страницам приложения(каждый раз приходится перходить из командной строки с добавлением логина и пароля)
пока обойти это не смог.

![Снимок18 13 выполнения кода](https://user-images.githubusercontent.com/101470215/187063256-88b46d07-69d1-4a8e-a638-c735edcc1653.PNG)
![Снимок18 14 выполнения кода](https://user-images.githubusercontent.com/101470215/187063260-ec3ca48e-cae8-47a1-a5e7-b4d63fbf57ff.PNG)
