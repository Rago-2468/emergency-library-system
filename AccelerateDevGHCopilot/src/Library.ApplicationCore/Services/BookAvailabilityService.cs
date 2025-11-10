using Library.ApplicationCore.Entities;

namespace Library.ApplicationCore.Services;

public class BookAvailabilityService : IBookAvailabilityService
{
    private readonly ILoanRepository _loanRepository;

    public BookAvailabilityService(ILoanRepository loanRepository)
    {
        _loanRepository = loanRepository;
    }

    public async Task<bool> IsBookAvailable(int bookItemId)
    {
        var activeLoans = await _loanRepository.GetActiveLoansForBook(bookItemId);
        return !activeLoans.Any();
    }

    public async Task<DateTime?> GetBookDueDate(int bookItemId)
    {
        var activeLoans = await _loanRepository.GetActiveLoansForBook(bookItemId);
        return activeLoans.FirstOrDefault()?.DueDate;
    }

    public async Task<(bool isAvailable, DateTime? dueDate, string? currentPatronName)> GetBookAvailabilityDetails(int bookItemId)
    {
        var activeLoans = await _loanRepository.GetActiveLoansForBook(bookItemId);
        var currentLoan = activeLoans.FirstOrDefault();

        return currentLoan == null
            ? (true, null, null)
            : (false, currentLoan.DueDate, currentLoan.Patron?.Name);
    }
}