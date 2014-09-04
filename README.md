飞行棋小游戏
============

flying chess written with cocos2d-x 3.X


构建说明
------

1. 基于cocos2d-x 3.x，开发时所使用的版本是 3.2
2. cocos2d请使用release包，并且使用了一些附加库(比如tinyxml2)
3. 配置完cocos2d后请使用cocos2d工具新建一个项目，并把其中的cocos2d目录复制过来覆盖这里的cocos2d目录
4. 当然如果你对cocos2d很熟悉也可以跳过上一步，但是需要手动设置依赖的项目工程


```bash
# cocos2d 初始化
./setup.py -n [NDK_ROOT] -a [ADT_ROOT] -t [ANT_ROOT]

# cocos2d 安装附加组件
./download-deps.py

```