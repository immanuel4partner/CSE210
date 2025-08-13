using Xunit;

public class GoalTests
{
    [Fact]
    public void SimpleGoal_ShouldBeComplete_AfterRecordEvent()
    {
        var goal = new SimpleGoal("Pray", "Daily prayer", 100);
        goal.RecordEvent();
        Assert.True(goal.IsComplete());
    }

    [Fact]
    public void EternalGoal_ShouldNeverBeComplete()
    {
        var goal = new EternalGoal("Read Scriptures", "Read every day", 50);
        goal.RecordEvent();
        Assert.False(goal.IsComplete());
    }

    [Fact]
    public void ChecklistGoal_ShouldReturnBonusPoints_WhenTargetReached()
    {
        var goal = new ChecklistGoal("Temple", "Attend 3 times", 50, 3, 200);
        goal.RecordEvent(); // +50
        goal.RecordEvent(); // +50
        int finalPoints = goal.RecordEvent(); // +50 + 200
        Assert.Equal(250, finalPoints);
        Assert.True(goal.IsComplete());
    }

    [Fact]
    public void ChecklistGoal_ShouldNotBeComplete_IfBelowTarget()
    {
        var goal = new ChecklistGoal("Fast", "Monthly fasting", 50, 4, 300);
        goal.RecordEvent();
        Assert.False(goal.IsComplete());
    }
}