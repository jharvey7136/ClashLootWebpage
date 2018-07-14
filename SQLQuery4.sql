Create procedure [dbo].[DeleteRecord]  
(  
   @Id int  
)  
as   
begin  
   Delete from LootRecords where Id=@Id  
End