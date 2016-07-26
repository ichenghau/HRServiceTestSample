Feature: 取得人員資訊
	In order to 可以找到人員資訊
	As a 人資人員
	I want to 取得人員資訊清單

@取得人員資訊
Scenario: 取得人員資訊，欄位需要有員工編號、姓名、部門名稱、職稱
	Given 人員為"PersonModel"的資料
	| Empno | Name | Dpt  | JobTitle |
	| A01   | 陳怡臻  | 0001 | 創辦人      |
	And 部門為"DepartMentModel"的資料
	| Dpt | Name | 
	| 0001   | 創辦室  | 
	When 取得人員資訊
	Then 人員資訊取得為"PersonInfo"的資料
	| Empno | UserName | DptName | JobTitle |
	| A01   | 陳怡臻      | 創辦室     | 創辦人      |

Scenario: 取得人員資訊，依員工編號排序
	Given 人員為"PersonModel"的資料
	| Empno | Name | Dpt  | JobTitle |
	| A02   | 龔柔心  | 0002 | 研究員      |
	| A01   | 陳怡臻  | 0001 | 創辦人      |
	| A03   | 林智仁  | 0002 | 研究經理      |
	And 部門為"DepartMentModel"的資料
	| Dpt | Name | 
	| 0001   | 創辦室  | 
	| 0002   | 研究室  | 
	When 取得人員資訊
	Then 人員資訊取得為"PersonInfo"的資料
	| Empno | UserName | DptName | JobTitle |
	| A01   | 陳怡臻      | 創辦室     | 創辦人      |
	| A02   | 龔柔心      | 研究室     | 研究員      |
	| A03   | 林智仁      | 研究室     | 研究經理     |
