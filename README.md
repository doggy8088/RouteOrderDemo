# RouteOrderDemo

請開啟 [Controllers/OrdersController.cs](Controllers/OrdersController.cs) 查看程式碼。

執行專案

```sh
dotnet run
```

測試網址：

- https://localhost:5001/orders/pending
- https://localhost:5001/orders/details
- https://localhost:5001/orders/123
- https://localhost:5001/orders/hello
- https://localhost:5001/orders/2020/8/10

## 路由套用順序 (Route Order)

1. 純字串、無參數、無限定詞的路由 (Literal segments)
2. 先比對是否設定路由順序 ( Order ) (預設值為 0)

    > Order 所設定的數字越小，優先權越高

3. 有路由參數，且有套用限定詞
4. 有路由參數，且無套用限定詞
5. 有萬用路由參數 (Wildcard parameter) 且有套用限定詞
6. 有萬用路由參數 (Wildcard parameter) 且無套用限定詞
