#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace backend.Models
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Exercise> Exercises { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DateCompleted { get; set; }
    }
    public class Exercise
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Workout")]
        public int WorkoutId { get; set; }
        public Workout Workout { get; set; }
        public string Name { get; set; }
        [EnumDataType(typeof(MuscleGroup))]
        public MuscleGroup MuscleGroup { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int RestBetweenSets { get; set; }
        public int RestBetweenExercises { get; set; }
    }
    public enum MuscleGroup
    {
        Biceps, Triceps, Deltoid, Forearm, Chest, Back, Trapezius, Quads, Hamstrings, Calves, Glutes
    }

    public class UserWeight
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public User User { get; set; }
        public float Weight { get; set; }
        public DateTime DateAdded { get; set; }
    }
}