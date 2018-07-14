Create procedure [dbo].[AddNewRecord]
(
	@dateNow date,
	@gold int,
	@elixer int,
	@dark int,
	@trophies int
)
as
begin
	insert into LootRecords values(@dateNow, @gold, @elixer, @dark, @trophies)
end