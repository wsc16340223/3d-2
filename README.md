# 简单题
### 游戏对象运动的本质是什么

 对象位置的改变

### 请用三种方法以上方法，实现物体的抛物线运动。（如，修改Transform属性，使用向量Vector3的方法…）

1.Translate方法

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float speedx = 2;
    public float speedy = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Translate(Vector3.right * speedx * Time.deltaTime);
        this.transform.Translate(Vector3.down * (10 * Time.deltaTime * Time.deltaTime / 2 + speedy * Time.deltaTime));
        speedy += 10;
    }
}
```

2.直接修改position

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float speedx = 2;
    public float speedy = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += Vector3.right * speedx * Time.deltaTime;
        this.transform.position += Vector3.down * (10 * Time.deltaTime * Time.deltaTime / 2 + speedy * Time.deltaTime);
        speedy += 10;
    }
}
```

3.Vector3方法

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    //public float speedx = 2;
    //public float speedy = 0;
    private Vector3 speedx;
    private Vector3 speedy;
    private Vector3 a;
    private float step;
    
	// Use this for initialization
	void Start () {
        speedx = new Vector3(20, 0, 0);
        speedy = new Vector3(0, 0, 0);
        a = new Vector3(0, 10, 0);
        step = Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 target = this.transform.position + (speedx + speedy) * step;
        this.transform.position = Vector3.MoveTowards(this.transform.position, target, step);
        speedy -= a * step;
    }
}
```

