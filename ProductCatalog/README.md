# ProductCatalog

상품 카탈로그를 출력하는 프로그램을 작성하시오.

**요구사항**

- o`Product` 클래스를 만들고, `Name`(이름), `Price`(가격) 속성을 가짐
- o`Product` 클래스의 `ToString()`을 오버라이드하여 "[이름] - ₩[가격:N0]" 형식으로 반환함
- o`Product` 클래스에 `virtual` 메서드 `GetDescription()`을 만들고, 기본 설명을 반환함
- o`Electronics` 클래스는 `Product`를 상속받고, 
- `Warranty`(보증기간, 개월) 속성을 추가함
  o- `ToString()`을 오버라이드하여 부모의 `ToString()` + " (보증: [기간]개월)" 형식으로 반환함
  o- `GetDescription()`을 오버라이드하여 전자제품 전용 설명을 반환함
- `Clothing` 클래스는 `Product`를 상속받고, `Size`(사이즈) 속성을 추가함
  - `ToString()`을 오버라이드하여 부모의 `ToString()` + " (사이즈: [사이즈])" 형식으로 반환함
  - `GetDescription()`을 오버라이드하여 의류 전용 설명을 반환함
- `Food` 클래스는 `Product`를 상속받고, `ExpirationDate`(유통기한) 속성을 추가함
  - `ToString()`을 오버라이드하여 부모의 `ToString()` + " (유통기한: [날짜])" 형식으로 반환함
  - `GetDescription()`을 오버라이드하여 식품 전용 설명을 반환함
- 다양한 상품을 `Product[]` 배열에 담고 출력함

## 예상 실행 결과

```
=== 상품 카탈로그 ===
노트북 - ₩1,500,000 (보증: 24개월)
  → 전자기기입니다. 취급에 주의하세요.
청바지 - ₩89,000 (사이즈: M)
  → 의류입니다. 세탁 방법을 확인하세요.
우유 - ₩3,500 (유통기한: 2026-06-15)
  → 식품입니다. 냉장 보관하세요.
```
