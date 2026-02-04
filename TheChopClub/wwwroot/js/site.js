// ===================================
// THE CHOP CLUB - Custom JavaScript
// ===================================

document.addEventListener('DOMContentLoaded', function () {
    console.log('🎯 The Chop Club loaded!');

    // Auto-hide alerts after 5 seconds
    const alerts = document.querySelectorAll('.alert');
    alerts.forEach(alert => {
        if (!alert.classList.contains('alert-permanent')) {
            setTimeout(() => {
                alert.style.transition = 'opacity 0.5s ease';
                alert.style.opacity = '0';
                setTimeout(() => alert.remove(), 500);
            }, 5000);
        }
    });

    // Add fade-in animation to cards
    const cards = document.querySelectorAll('.card');
    cards.forEach((card, index) => {
        card.style.animationDelay = `${index * 0.1}s`;
        card.classList.add('fade-in');
    });

    // Confirm delete actions
    const deleteButtons = document.querySelectorAll('[data-confirm-delete]');
    deleteButtons.forEach(button => {
        button.addEventListener('click', function (e) {
            if (!confirm('Tem a certeza que deseja eliminar?')) {
                e.preventDefault();
            }
        });
    });

    // Image preview for file uploads
    const imageInputs = document.querySelectorAll('input[type="file"][accept*="image"]');
    imageInputs.forEach(input => {
        input.addEventListener('change', function (e) {
            const file = e.target.files[0];
            if (file) {
                const reader = new FileReader();
                reader.onload = function (e) {
                    const preview = document.querySelector('#image-preview');
                    if (preview) {
                        preview.src = e.target.result;
                        preview.style.display = 'block';
                    }
                };
                reader.readAsDataURL(file);
            }
        });
    });
});

// Like Post Function
async function likePost(postId) {
    try {
        const button = event.target.closest('button');
        button.disabled = true;

        // Simular incremento (em produção seria um POST ao servidor)
        const likesSpan = document.getElementById(`likes-${postId}`);
        const currentLikes = parseInt(likesSpan.textContent);
        likesSpan.textContent = currentLikes + 1;

        // Animação
        button.classList.add('btn-danger');
        button.classList.remove('btn-outline-danger');

        setTimeout(() => {
            button.disabled = false;
        }, 1000);

    } catch (error) {
        console.error('Erro ao dar like:', error);
        alert('Erro ao processar o like. Tente novamente.');
    }
}

// Format Number
function formatNumber(num) {
    if (num >= 1000000) {
        return (num / 1000000).toFixed(1) + 'M';
    } else if (num >= 1000) {
        return (num / 1000).toFixed(1) + 'K';
    }
    return num.toString();
}

// Show Loading Spinner
function showLoading() {
    const spinner = document.createElement('div');
    spinner.id = 'global-spinner';
    spinner.className = 'd-flex justify-content-center align-items-center position-fixed top-0 start-0 w-100 h-100 bg-dark bg-opacity-50';
    spinner.style.zIndex = '9999';
    spinner.innerHTML = `
        <div class="spinner-border text-light" role="status">
            <span class="visually-hidden">A carregar...</span>
        </div>
    `;
    document.body.appendChild(spinner);
}

function hideLoading() {
    const spinner = document.getElementById('global-spinner');
    if (spinner) {
        spinner.remove();
    }
}

// Smooth Scroll
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            target.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }
    });
});