### 排列出太阳系各行星位置

![s](http://r.photo.store.qq.com/psb?/V130IzoX3J4uRT/6f7U7.O9mwzVFYvDcV*H1zcaQW2SYILuj.Wi6RYCPFI!/r/dGEBAAAAAAAA 'solar')

- 太阳和各行星都上了贴图，不过因为在太阳上添加了golw11组件使太阳发光，已看不见贴图

### 运动时的轨迹图

![solar](http://r.photo.store.qq.com/psb?/V130IzoX3J4uRT/8kbRrX6kUCAYYZblwD0Hz*TsWUZFOC9Jz.G6ttIKt20!/r/dEUBAAAAAAAA 'solar')
![solar](http://r.photo.store.qq.com/psb?/V130IzoX3J4uRT/YYncGQ1TWMALVS7TZh4LgXBML6kl4ldTs3vFKq3cDH0!/r/dGEBAAAAAAAA 'solar')
![solar](http://r.photo.store.qq.com/psb?/V130IzoX3J4uRT/Rbm59qEjT*MOCBBafa.5nhb5TB4o404Ax6sK0IuOXcI!/r/dDEBAAAAAAAA 'solar')


### 太阳代码

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunrorate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * 30 * Time.deltaTime);
	}
}

```

### 行星代码

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetrotate : MonoBehaviour {

    public Transform sun;
    public float speed = 10;
    float rty, rtz;

	// Use this for initialization
	void Start () {
        rty = Random.Range(1, 360);
        rtz = Random.Range(1, 360);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 axis = new Vector3(0, rty, rtz);
        this.transform.RotateAround(sun.position, axis, speed * Time.deltaTime);
	}
}

```
