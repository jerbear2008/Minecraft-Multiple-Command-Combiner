# Minecraft Multiple Command Combiner
 Open source program for combine many commands into one command block in minecraft
The program an option for all versions from 1.8.x to 1.16.x
# Example
Here is a small example created with the program (1.12.x to 1.11.x) which will display created a block command which will display in your chat "test" and "test2" to finally self-destruct
![App Screen](/Media/Gen.png)
```
summon falling_block ~ ~1 ~ {Block:stone,Time:1,Passengers:[{id:falling_block,Block:redstone_block,Time:1,Passengers:[{id:falling_block,Block:activator_rail,Time:1,Passengers:[{id:commandblock_minecart,Command:"say test"},{id:commandblock_minecart,Command:"say test2"},{id:commandblock_minecart,Command:"setblock ~ ~ ~1 command_block 0 0 {Command:\"fill ~ ~-3 ~-1 ~ ~ ~ air\"}"},{id:commandblock_minecart,Command:"setblock ~ ~-1 ~1 redstone_block"},{id:commandblock_minecart,Command:"kill @e[type=commandblock_minecart,r=1]"}]}]}]}
```
![Minecraft Gif](/Media/GenUse.gif)

Note: it is recommended to disable the CommandBlockOutput gamerule