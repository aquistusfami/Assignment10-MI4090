# NOTE

- `Device`: we have 3 devices
  1. `SmartLight`
  2. `SmartFan`
  3. `SmartDoor` 
- **Requirements:**
  1. `Device` might be **turned on, off**. for `SmartDoor`, it could be **locked or unlocked.**
  2. program create device based on user choice.
  3. general configuration of the smart house only one specification used in the app.
  4. user has to activate the house's modes like **Work or Sleep** but not having to call device separately.
  5. The design must allow client to work mainly through abstraction directly instead of rely directly on specified class.

Pattern i'd like to use


| Problems                                                                                  | Components          | Pattern     |
| ----------------------------------------------------------------------------------------- | ------------------- | ----------- |
| tach viec tao `Device` khoi client                                                        | `DeviceFactory`     | `Factory`   |
| Chia se 1 cau hinh ung dung                                                               | `HomeConfiguration` | `Singleton` |
| Cung cap thao tac cho nhieu thiet bi kieu (sleep thi tat den, bat quat muc vua, dong cua) | `SmartHomeFacade`   | `Facade`    |


 