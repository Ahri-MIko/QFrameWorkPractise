# QFramework Practice · QFramework 学习实践

> 基于 Unity 的 QFramework 框架学习与实践项目。
>
> 以一个简单的"点击消灭敌人"小游戏为载体，逐步学习和接入 QFramework 的各项核心能力。

[![Unity](https://img.shields.io/badge/Unity-2022.3.55f1c1-57B9E7?logo=unity)](https://unity.com/)
[![QFramework](https://img.shields.io/badge/Framework-QFramework-8B5CF6)](https://github.com/liangxiegame/QFramework)
[![Status](https://img.shields.io/badge/Status-Learning%20in%20Progress-FF6B6B)]()

---

## 📖 项目简介

本项目是 QFramework 框架的学习实践工程。项目以一个极简的点击类小游戏为起点，目标是在开发过程中逐步引入 QFramework 的核心模块，理解其架构思想并应用到实际项目中。

**当前版本（Ver1）** 已实现基础游戏循环：
- 开始界面 → 点击开始按钮 → 出现 4 个敌人 → 逐个点击消灭 → 全部消灭后显示通关面板

后续将在此基础上逐步接入 QFramework 的各个系统。

---

## 🎮 游戏玩法

1. 游戏启动后显示**开始面板**，点击「开始」按钮
2. 场景中出现 **4 个敌人**
3. 用鼠标**点击敌人**将其消灭（每消灭一个计数 +1）
4. 消灭全部 4 个敌人后，显示**通关面板**，游戏结束

---

## 📂 项目结构

```
QFrameWorkPractise/
├── Point/                          # Unity 项目根目录
│   ├── Assets/
│   │   ├── Scenes/
│   │   │   └── SampleScene.unity   # 主场景
│   │   └── Scripts/
│   │       ├── GameStartPanel.cs   # 开始面板（开始按钮逻辑）
│   │       ├── Enemy.cs            # 敌人（点击销毁 + 计数 + 通关判定）
│   │       ├── GameOverUI.cs       # 游戏结束 UI（待实现）
│   │       └── Test.cs             # 测试脚本
│   ├── Packages/
│   │   ├── manifest.json           # 包依赖清单
│   │   └── packages-lock.json      # 包锁定版本
│   ├── ProjectSettings/            # Unity 项目设置
│   └── UserSettings/               # 编辑器用户设置
└── Unity.gitignore
```

---

## 🧩 核心脚本说明

### GameStartPanel.cs

开始面板控制器。点击开始按钮后隐藏自身，并激活敌人群组。

```csharp
BtnGameStart.onClick.AddListener(() => {
    gameObject.SetActive(false);   // 隐藏开始面板
    Enemies.SetActive(true);       // 显示敌人
});
```

### Enemy.cs

敌人控制器。使用 `OnMouseDown()` 检测点击，销毁自身并递增静态计数器；当计数达到 4 时显示通关面板。

```csharp
public static int EnemyCount = 0;

void OnMouseDown()
{
    EnemyCount++;
    Destroy(gameObject);
    if (EnemyCount == 4)
    {
        GamePassPanel.SetActive(true);
    }
}
```

### GameOverUI.cs / Test.cs

预留脚本，待后续实现。

---

## 🎯 QFramework 学习路线

> QFramework 是一套由凉宫逗（liangxiegame）维护的 Unity 快速开发框架，提供了架构、工具、扩展方法等一整套开发能力。
>
> 项目地址：https://github.com/liangxiegame/QFramework

以下是计划逐步学习和接入的 QFramework 核心模块：

| 模块 | 说明 | 应用场景 |
|------|------|----------|
| **Architecture 架构** | Controller / Model / System / Utility 分层，支持 Interface 注入与 Singleton | 重构当前散乱的脚本，建立清晰的项目架构 |
| **Event 事件系统** | 类型安全的事件发送与接收，支持泛型参数 | 替代 `static int EnemyCount`，用事件驱动 UI 更新 |
| **DataNode 数据节点** | 树形数据存储，支持数据绑定 | 管理游戏进度、分数、设置等数据 |
| **Audio 音频系统** | 背景音乐 / 音效播放管理，支持对象池 | 添加 BGM 和点击音效 |
| **UI Kit UI 系统** | UI 面板管理、层级管理、屏幕适配 | 规范化开始面板 / 通关面板 / 结束面板 |
| **Res Kit 资源管理** | 异步加载、对象池、AB 包支持 | 动态加载敌人预制体和 UI 面板 |
| **Counter 计数器** | 可绑定的数值计数器，支持事件订阅 | 替代手动计数，自动驱动 UI 刷新 |
| **FSM 有限状态机** | 通用状态机实现 | 管理游戏流程状态（开始 / 进行中 / 通关 / 失败） |
| **BindableProperty** | 可绑定属性，值变化时触发事件 | 敌人数、分数等数据的响应式更新 |
| **Singleton 单例** | 泛型单例基类（Mono / 非 Mono） | 游戏管理器、音频管理器等 |

---


## 📈 版本记录

| 版本 | 日期 | 内容 |
|------|------|------|
| **Ver1** | 2025-05-14 | 初始版本：基础游戏循环（开始面板 → 点击消灭 4 敌人 → 通关面板） |

---

## 👤 开发者

- **zraycheng** — 学习与开发

---

