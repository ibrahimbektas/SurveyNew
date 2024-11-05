using DtoLayer.Dtos.CreatorDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidatonRules.CreatorValidationRules
{
	public class CreatorRegisterValidator : AbstractValidator<CreatorRegisterDto>
	{
		public CreatorRegisterValidator() 
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş bırakılamaz");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz");
			RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Parola alanı boş bırakılamaz");
			RuleFor(x => x.CconfirmPassword).NotEmpty().WithMessage("Parola tekrar alanı boş bırakılamaz");
			RuleFor(x => x.Name).MaximumLength(30).WithMessage("En fazla 30 karekter girişi yapabilirsiniz");
			RuleFor(x => x.Name).MinimumLength(2).WithMessage("En az 2 karekter girmelisiniz");
			RuleFor(x => x.CconfirmPassword).Equal(y => y.Password).WithMessage("Parolalar eşleşmiyor");
			RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");

		}
	}
}
