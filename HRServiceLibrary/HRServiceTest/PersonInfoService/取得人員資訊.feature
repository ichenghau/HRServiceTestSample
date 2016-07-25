Feature: 取得人員資訊
	In order to 可以找到人員資訊
	As a 人資人員
	I want to 取得人員資訊清單

@mytag
Scenario: 取得人員資訊
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
