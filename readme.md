# ShortCommands

Этот плагин полезен для администраторов серверов Terraria, которые хотят упростить выполнение часто используемых команд или создать набор макрокоманд для выполнения нескольких действий сразу. Например, администратор может создать короткую команду для выдачи определенных предметов, изменения времени или других действий, которые часто требуются на сервере.

## Поддержка параметров 

Плагин поддерживает замену параметров в сокращенных командах на основе пользовательского ввода. Это осуществляется с помощью специальных маркеров, таких как {0}, {+}, {player} и {website}, которые заменяются значениями в зависимости от контекста.

- {0}, {1}, и так далее — заменяются на параметры команды, переданные игроком.
- {+} — заменяется на все оставшиеся параметры, переданные командой.
- {player} — заменяется на имя аккаунта игрока.
- {website} — заменяется на URL сайта, указанный в конфигурации.