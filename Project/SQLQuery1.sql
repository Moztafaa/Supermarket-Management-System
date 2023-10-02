select PRODID as ProductID, PRODNAME as ProductName
from PRODUCT
where PRODID in (
	select	p_id
	from HAS
	group by p_id
	having COUNT(P_ID) = (
		select MAX(counter)
		from (select COUNT(*) as counter 
			  from HAS
			  group by p_id
			 ) as c
		)
	)

	/*(2)***********************************************************************************/
	select ProdName, ProdId from Product where ProdId not in (select p_id from HAS) 
	/****(3)****************************************/

	select customerid ,customerName from orders where customerid not in(select user_id from MAKE)
	and sellDate < ( DATEADD(year,-1,GETDATE()));

	/*(4)*************************************************/

	select	UserId from [User] where UserId  in (
	select CUSTOMERID from ORDERS where TotalAmt =(select max(TotalAmt) from ORDERS) and sellDate = DATEADD(month,0,GETDATE()))
	

	/***(5)*/
	select count(CatName) as electric from CATEGORY where CatName = 'Electric'
	select count(CatName) as food from CATEGORY where CatName = 'Food' 

	/*(6)*/
	select * from PRODUCT
	