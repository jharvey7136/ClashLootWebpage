Create procedure [dbo].[UpdateLootRecord]
(
	@dateNow date,
	@gold int,
	@elixer int,
	@dark int,
	@trophies int
)
as
begin
	Update LootRecords
	set dateNow=@dateNow,
		gold=@gold,
		elixer=@elixer,
		dark=@dark,
		trophies=@trophies
End