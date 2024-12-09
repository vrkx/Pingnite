@echo off

echo.  ____                                    __             
echo. /\  _`\   __                          __/\ \__      
echo.   \ \ \L\ \/\_\    ___      __     ___ /\_\ \ ,_\    __   
echo. \ \ ,__/\/\ \ /' _ `\  /'_ `\ /' _ `\/\ \ \ \/  /'__`\ 
echo.  \ \ \/  \ \ \/\ \/\ \/\ \L\ \/\ \/\ \ \ \ \ \_/\  __/ 
echo.   \ \_\   \ \_\ \_\ \_\ \____ \ \_\ \_\ \_\ \__\ \____\
echo.    \/_/    \/_/\/_/\/_/\/___L\ \/_/\/_/\/_/\/__/\/____/
echo.                          /\____/                       
echo.                          \_/__/                        
echo.
echo.
echo  Pingnite made by @vrkx
echo.
echo  Fortnite Servers (This may take a few seconds) :
echo.
COLOR 01
echo.
echo  NA-EAST Ping :
echo.
ping -n 4 ping-nae.ds.on.epicgames.com 
echo.
echo  NA-CENTRAL Ping :
echo.
ping -n 4 ping-nac.ds.on.epicgames.com | FIND "Average"
echo.
echo  NA-WEST Ping :
echo.
ping -n 4 ping-naw.ds.on.epicgames.com | FIND "Average"
echo.
echo  EUROPE Ping :
echo.
ping -n 4 ping-eu.ds.on.epicgames.com  | FIND "Average"
echo.
echo  OCEANIA Ping :
echo.
ping -n 4 ping-oce.ds.on.epicgames.com  | FIND "Average"
echo.
echo  BRAZIL Ping :
echo.
ping -n 4 ping-br.ds.on.epicgames.com  | FIND "Average"
echo.
echo  ASIA Ping :
echo.
ping -n 4 ping-asia.ds.on.epicgames.com  | FIND "Average"
echo.
echo  MIDDLE-EAST Ping :
echo.
ping -n 4 ping-me.ds.on.epicgames.com  | FIND "Average"
echo.

pause