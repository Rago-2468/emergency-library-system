using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore;

public interface IBookAvailabilityService
{
    /// <summary>
    /// Checks if a specific book item is available for loan
    /// </summary>
    /// <param name="bookItemId">The ID of the book item to check</param>
    /// <returns>True if the book is available, false otherwise</returns>
    Task<bool> IsBookAvailable(int bookItemId);

    /// <summary>
    /// Gets the expected return date for a book that is currently on loan
    /// </summary>
    /// <param name="bookItemId">The ID of the book item to check</param>
    /// <returns>The due date if the book is on loan, null if the book is available</returns>
    Task<DateTime?> GetBookDueDate(int bookItemId);

    /// <summary>
    /// Gets detailed availability information for a book
    /// </summary>
    /// <param name="bookItemId">The ID of the book item to check</param>
    /// <returns>A tuple containing (isAvailable, dueDate, currentPatronName)</returns>
    Task<(bool isAvailable, DateTime? dueDate, string? currentPatronName)> GetBookAvailabilityDetails(int bookItemId);
}